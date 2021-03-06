// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.Server.SchemaManagement.OleDbProvider
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Text.RegularExpressions;
    using Zetbox.API;
    using Zetbox.API.Server;

    public class OleDb
        : ISchemaProvider
    {
        private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Zetbox.Server.Schema.OLEDB");
        private readonly static log4net.ILog QueryLog = log4net.LogManager.GetLogger("Zetbox.Server.Schema.OLEDB.Queries");

        private string currentConnectionString;

        protected OleDbConnection db;
        protected OleDbTransaction tx;
        protected string quotePrefix;
        protected string quoteSuffix;

        public string ConfigName { get { return "OLEDB"; } }
        public string AdoNetProvider { get { return null; } }
        public string ManifestToken { get { return null; } }
        public bool IsStorageProvider { get { return false; } }

        public void Open(string connectionString)
        {
            if (db != null)
                throw new InvalidOperationException("Database already opened");
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");
            if (IntPtr.Size == 8)
                throw new InvalidOperationException("Cannot open MDB in 64bit process, since there is no 64bit OLEDB driver (as of 2011-05-31)");

            currentConnectionString = connectionString;
            db = new OleDbConnection(currentConnectionString);
            db.Open();

            DataTable literals = db.GetOleDbSchemaTable(OleDbSchemaGuid.DbInfoLiterals, new object[] { });
            literals.PrimaryKey = new DataColumn[] { literals.Columns["Literal"] };
            DataRow row = null;
            row = literals.Rows.Find((int)OleDbLiteral.Quote_Prefix);
            if (row != null)
                quotePrefix = row["LiteralValue"] as string;
            row = literals.Rows.Find((int)OleDbLiteral.Quote_Suffix);
            if (row != null)
                quoteSuffix = row["LiteralValue"] as string;
        }

        public void Close()
        {
            if (db != null)
            {
                db.Close();
                db = null;
                currentConnectionString = null;
            }
        }

        public string GetSafeConnectionString()
        {
            return currentConnectionString;
        }

        public string GetSafeConnectionString(string connectionString)
        {
            // no password here, please move on!
            return connectionString;
        }

        public void BeginTransaction()
        {
            if (tx != null)
                throw new InvalidOperationException("Transaction is already running");
            tx = db.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (tx != null)
            {
                tx.Commit();
                tx = null;
            }
        }

        public void RollbackTransaction()
        {
            if (tx != null)
            {
                tx.Rollback();
                tx = null;
            }
        }

        public void Dispose()
        {
            if (tx != null)
            {
                tx.Rollback();
                tx.Dispose();
                tx = null;
            }

            if (db != null)
            {
                db.Close();
                db.Dispose();
                db = null;
            }
        }

        public string QuoteIdentifier(string val)
        {
            return string.Format("{0}{1}{2}", quotePrefix ?? string.Empty, val, quoteSuffix ?? string.Empty);
        }

        private string FormatSchemaName(DboRef dbo)
        {
            if (string.IsNullOrWhiteSpace(dbo.Schema))
            {
                return QuoteIdentifier(dbo.Name);
            }
            else
            {
                return String.Format("{0}.{1}", QuoteIdentifier(dbo.Schema), QuoteIdentifier(dbo.Name));
            }
        }

        public bool CheckTableExists(TableRef tblName)
        {
            if (tblName == null)
                throw new ArgumentNullException("tblName");

            return GetTableNames().Any(t => t == tblName);
        }

        public bool CheckColumnExists(TableRef tblName, string colName)
        {
            if (tblName == null)
                throw new ArgumentNullException("tblName");

            return GetTableColumnNames(tblName).Any(c => c == colName);
        }

        public bool GetIsColumnNullable(TableRef tblName, string colName)
        {
            if (tblName == null)
                throw new ArgumentNullException("tblName");

            return GetTableColumns(tblName).Single(c => c.Name == colName).IsNullable;
        }

        public bool CheckViewExists(TableRef viewName)
        {
            if (viewName == null)
                throw new ArgumentNullException("viewName");

            return GetViewNames().Any(v => v == viewName);
        }

        public bool CheckTableContainsData(TableRef tblName)
        {
            if (tblName == null)
                throw new ArgumentNullException("tblName");

            using (var cmd = new OleDbCommand(string.Format("SELECT COUNT(*) FROM {0}", FormatSchemaName(tblName), db, tx)))
            {
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckColumnContainsNulls(TableRef tblName, string colName)
        {
            if (tblName == null)
                throw new ArgumentNullException("tblName");

            using (var cmd = new OleDbCommand(string.Format("SELECT COUNT(*) FROM (SELECT TOP 1 {1} FROM {0} WHERE {1} IS NULL) AS nulls", FormatSchemaName(tblName), QuoteIdentifier(colName)), db, tx))
            {
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckFKColumnContainsUniqueValues(TableRef tblName, string colName)
        {
            using (var cmd = new OleDbCommand(string.Format("SELECT COUNT(*) FROM (SELECT TOP 1 {1} FROM {0} WHERE {1} IS NOT NULL GROUP BY {1} HAVING COUNT({1}) > 1) AS tbl", FormatSchemaName(tblName), QuoteIdentifier(colName)), db, tx))
            {
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() == 0;
            }
        }

        public bool CheckColumnContainsValues(TableRef tblName, string colName)
        {
            using (var cmd = new OleDbCommand(string.Format("SELECT COUNT(*) FROM (SELECT TOP 1 {1} FROM {0} WHERE {1} IS NOT NULL) AS nulls", FormatSchemaName(tblName), QuoteIdentifier(colName)), db, tx))
            {
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public TableRef GetTableName(string schemaName, string tblName)
        {
            return new TableRef(db.Database, schemaName, tblName);
        }

        public IEnumerable<TableRef> GetTableNames()
        {
            QueryLog.Debug("GetSchema(TABLES)");
            var tables = db.GetSchema(OleDbMetaDataCollectionNames.Tables, new string[] { null, null, null, "TABLE" });
            foreach (DataRow tbl in tables.Rows)
            {
                var schema = tbl["TABLE_SCHEMA"] ?? DBNull.Value;
                yield return GetTableName(schema == DBNull.Value ? String.Empty : schema.ToString(), (string)tbl["TABLE_NAME"]);
            }
        }

        public IEnumerable<TableRef> GetViewNames()
        {
            QueryLog.Debug("GetSchema(VIEWS)");
            var views = db.GetSchema(OleDbMetaDataCollectionNames.Views);
            foreach (DataRow tbl in views.Rows)
            {
                yield return GetTableName((string)tbl["TABLE_SCHEMA"], (string)tbl["TABLE_NAME"]);
            }
        }

        public string GetViewDefinition(TableRef view)
        {
            if (view == null) return null;

            var views = db.GetSchema(OleDbMetaDataCollectionNames.Views, new string[] { null, null, view.Name });
            if (views.Rows.Count != 1)
            {
                throw new InvalidOperationException(string.Format("Did not get exactly one result for View {0}", view));
            }
            var def = views.Rows[0]["VIEW_DEFINITION"];
            return def.ToString();
        }

        private class DataType
        {
            public string TypeName { get; set; }
            public int ProviderDbType { get; set; }
            public Type Type { get; set; }

            public override string ToString()
            {
                return string.Format("{0}: {1}", ProviderDbType, TypeName);
            }
        }

        private Dictionary<int, DataType> _DataTypes = null;
        private Dictionary<int, DataType> DataTypes
        {
            get
            {
                if (_DataTypes == null)
                {
                    _DataTypes = new Dictionary<int, DataType>();
                    foreach (DataRow dt in db.GetSchema("DataTypes").Rows)
                    {
                        int id = (int)dt["ProviderDbType"];
                        _DataTypes[id] = new DataType() { TypeName = (string)dt["TypeName"], Type = Type.GetType((string)dt["DataType"]), ProviderDbType = id };
                    }

                    // Add some more
                    _DataTypes[(int)OleDbType.Boolean] = new DataType() { Type = typeof(bool) };
                    _DataTypes[(int)OleDbType.TinyInt] = new DataType() { Type = typeof(short) };
                    _DataTypes[(int)OleDbType.Single] = new DataType() { Type = typeof(short) };
                    _DataTypes[(int)OleDbType.SmallInt] = new DataType() { Type = typeof(short) };
                    _DataTypes[(int)OleDbType.Integer] = new DataType() { Type = typeof(int) };
                    _DataTypes[(int)OleDbType.BigInt] = new DataType() { Type = typeof(long) };
                    _DataTypes[(int)OleDbType.UnsignedBigInt] = new DataType() { Type = typeof(ulong) };
                    _DataTypes[(int)OleDbType.UnsignedInt] = new DataType() { Type = typeof(uint) };
                    _DataTypes[(int)OleDbType.UnsignedSmallInt] = new DataType() { Type = typeof(ushort) };
                    _DataTypes[(int)OleDbType.UnsignedTinyInt] = new DataType() { Type = typeof(ushort) };

                    _DataTypes[(int)OleDbType.Char] = new DataType() { Type = typeof(char) };

                    _DataTypes[(int)OleDbType.WChar] = new DataType() { Type = typeof(string) };
                    _DataTypes[(int)OleDbType.VarWChar] = new DataType() { Type = typeof(string) };
                    _DataTypes[(int)OleDbType.VarChar] = new DataType() { Type = typeof(string) };
                    _DataTypes[(int)OleDbType.BSTR] = new DataType() { Type = typeof(string) };
                    _DataTypes[(int)OleDbType.LongVarChar] = new DataType() { Type = typeof(string) };
                    _DataTypes[(int)OleDbType.LongVarWChar] = new DataType() { Type = typeof(string) };

                    _DataTypes[(int)OleDbType.Binary] = new DataType() { Type = typeof(byte[]) };
                    _DataTypes[(int)OleDbType.LongVarBinary] = new DataType() { Type = typeof(byte[]) };
                    _DataTypes[(int)OleDbType.VarBinary] = new DataType() { Type = typeof(byte[]) };

                    _DataTypes[(int)OleDbType.Currency] = new DataType() { Type = typeof(decimal) };
                    _DataTypes[(int)OleDbType.Decimal] = new DataType() { Type = typeof(decimal) };
                    _DataTypes[(int)OleDbType.Double] = new DataType() { Type = typeof(double) };
                    _DataTypes[(int)OleDbType.Numeric] = new DataType() { Type = typeof(double) };

                    _DataTypes[(int)OleDbType.Date] = new DataType() { Type = typeof(DateTime) };
                    _DataTypes[(int)OleDbType.DBDate] = new DataType() { Type = typeof(DateTime) };
                    _DataTypes[(int)OleDbType.DBTime] = new DataType() { Type = typeof(DateTime) };
                    _DataTypes[(int)OleDbType.DBTimeStamp] = new DataType() { Type = typeof(DateTime) };
                    _DataTypes[(int)OleDbType.Filetime] = new DataType() { Type = typeof(DateTime) };

                    _DataTypes[(int)OleDbType.Guid] = new DataType() { Type = typeof(Guid) };

                }
                return _DataTypes;
            }
        }

        public IEnumerable<Column> GetTableColumns(TableRef tbl)
        {
            QueryLog.Debug("GetSchema(Columns)");
            var columns = db.GetSchema(OleDbMetaDataCollectionNames.Columns, new string[] { null, null, tbl.Name, null });
            foreach (DataRow col in columns.Rows)
            {
                int dt = (int)col["DATA_TYPE"];
                Type type = DataTypes.ContainsKey(dt) ? DataTypes[dt].Type : typeof(string);
                int size = (int)(col["CHARACTER_MAXIMUM_LENGTH"] as long? ?? 0);
                if (size == 0 && (type == typeof(string) || type == typeof(byte[])))
                {
                    size = int.MaxValue;
                }
                yield return new Column()
                {
                    Name = (string)col["COLUMN_NAME"],
                    Size = size,
                    IsNullable = (bool)col["IS_NULLABLE"],
                    Type = DbTypeMapper.GetDbType(type)
                };
            }
        }

        public IEnumerable<string> GetTableColumnNames(TableRef tblName)
        {
            QueryLog.Debug("GetSchema(Columns)");
            var columns = db.GetSchema(OleDbMetaDataCollectionNames.Columns, new string[] { null, null, tblName.Name, null });
            foreach (DataRow col in columns.Rows)
            {
                yield return (string)col["COLUMN_NAME"];
            }
        }

        public ProcRef GetProcedureName(string schemaName, string procName)
        {
            return new ProcRef(String.Empty, schemaName, procName);
        }

        public IEnumerable<ProcRef> GetProcedureNames()
        {
            var procs = db.GetSchema(OleDbMetaDataCollectionNames.Procedures);
            foreach (DataRow row in procs.Rows)
            {
                yield return GetProcedureName((string)row["PROCEDURE_SCHEMA"], (string)row["PROCEDURE_NAME"]);
            }
        }

        public string GetProcedureDefinition(ProcRef proc)
        {
            if (proc == null) return null;

            var procs = db.GetSchema(OleDbMetaDataCollectionNames.Procedures, new string[] { null, null, proc.Name });
            if (procs.Rows.Count != 1)
            {
                throw new InvalidOperationException(string.Format("Did not get exactly one result for Procedure {0}", proc));
            }
            var def = procs.Rows[0]["PROCEDURE_TYPE"] + Environment.NewLine + procs.Rows[0]["PROCEDURE_DEFINITION"];
            return def.ToString();
        }

        private void ExecuteNonQuery(string nonQueryFormat, params object[] args)
        {
            string query = String.Format(nonQueryFormat, args);

            using (var cmd = new OleDbCommand(query, db, tx))
            {
                QueryLog.Debug(query);
                cmd.ExecuteNonQuery();
            }
        }

        public void CopyColumnData(TableRef srcTblName, string srcColName, TableRef tblName, string colName)
        {
            Log.DebugFormat("Copying data from [{0}].[{1}] to [{2}].[{3}]", srcTblName, srcColName, tblName, colName);
            ExecuteNonQuery("UPDATE dest SET dest.[{0}] = src.[{1}] FROM [{2}] dest INNER JOIN [{3}] src ON dest.ID = src.ID",
                colName, srcColName, tblName, srcTblName);
        }

        public void CopyColumnData(TableRef srcTblName, string[] srcColName, TableRef tblName, string[] colName, string discriminatorValue)
        {
            if (srcColName == null) throw new ArgumentNullException("srcColName");
            if (colName == null) throw new ArgumentNullException("colName");
            if (srcColName.Length != colName.Length) throw new ArgumentOutOfRangeException("colName", "need the same number of columns in srcColName and colName");

            var assignments = srcColName.Zip(colName, (src, dst) => string.Format("{1} = src.{0}", QuoteIdentifier(src), QuoteIdentifier(dst))).ToList();
            if (discriminatorValue != null)
            {
                assignments.Add(string.Format("{0} = '{1}'", QuoteIdentifier(TableMapper.DiscriminatorColumnName), discriminatorValue));
            }

            if (assignments.Count > 0)
            {
                ExecuteNonQuery(string.Format(
                    "UPDATE dest SET {2} FROM {1} dest INNER JOIN {0} src ON dest.{3} = src.{3}",
                    FormatSchemaName(srcTblName),     // 0
                    FormatSchemaName(tblName),        // 1
                    string.Join(", ", assignments),   // 2
                    QuoteIdentifier("ID")));          // 3
            }
        }

        public void MigrateFKs(TableRef srcTblName, string srcColName, TableRef tblName, string colName)
        {
            Log.DebugFormat("Migrating FK data from [{0}].[{1}] to [{2}].[{3}]", srcTblName, srcColName, tblName, colName);
            ExecuteNonQuery("UPDATE dest SET dest.[{0}] = src.[ID] FROM [{2}] dest INNER JOIN [{3}] src ON dest.ID = src.[{1}]",
                colName, srcColName, tblName, srcTblName);
        }

        public void InsertFKs(TableRef srcTblName, string srcColName, TableRef tblName, string colName, string fkColName)
        {
            Log.DebugFormat("Inserting FK data from [{0}]([{1}]) to [{2}]([{3}],[{4}])", srcTblName, srcColName, tblName, colName, fkColName);
            ExecuteNonQuery("INSERT INTO [{0}] ([{1}], [{2}]) SELECT [ID], [{3}] FROM [{4}] WHERE [{3}] IS NOT NULL",
                tblName, colName, fkColName, srcColName, srcTblName);
        }

        public void CopyFKs(TableRef srcTblName, string srcColName, TableRef destTblName, string destColName, string srcFKColName)
        {
            Log.DebugFormat("Copy FK data from [{0}]([{1}]) to [{2}]([{3}])", srcTblName, srcColName, destTblName, destColName);
            ExecuteNonQuery("UPDATE dest SET dest.[{0}] = src.[{1}] FROM [{2}] dest  INNER JOIN [{3}] src ON src.[{4}] = dest.[ID]",
                destColName, srcColName, destTblName, srcTblName, srcFKColName);
        }

        public IDataReader ReadTableData(TableRef tbl, IEnumerable<string> colNames)
        {
            if (tbl == null)
                throw new ArgumentNullException("tbl");

            var sb = new StringBuilder();
            sb.AppendLine("SELECT ");
            colNames.ForEach(i => sb.Append(QuoteIdentifier(i) + ","));
            sb.Remove(sb.Length - 1, 1);
            sb.AppendLine(" FROM " + FormatSchemaName(tbl));

            var cmd = new OleDbCommand(sb.ToString(), db, tx);
            return cmd.ExecuteReader();
        }

        public IDataReader ReadTableData(string sql)
        {
            var cmd = new OleDbCommand(sql, db, tx);
            return cmd.ExecuteReader();
        }

        public IDataReader ReadJoin(TableRef tbl, IEnumerable<ProjectionColumn> colNames, IEnumerable<Join> joins)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public void WriteTableData(TableRef destTbl, IDataReader source, IEnumerable<string> colNames)
        {
            if (destTbl == null)
                throw new ArgumentNullException("destTbl");
            if (source == null)
                throw new ArgumentNullException("source");

            var values = new object[source.FieldCount];
            while (source.Read())
            {
                source.GetValues(values);
                WriteTableData(destTbl, this.GetTableColumnNames(destTbl), values);
            }
        }

        public void WriteTableData(TableRef tbl, IEnumerable<string> colNames, System.Collections.IEnumerable values)
        {
            if (tbl == null)
                throw new ArgumentNullException("tbl");
            if (colNames == null)
                throw new ArgumentNullException("colNames");
            if (values == null)
                throw new ArgumentNullException("values");

            var sb = new StringBuilder();
            sb.AppendLine(string.Format("INSERT INTO {0} (", FormatSchemaName(tbl)));

            colNames.ForEach(i => sb.Append(QuoteIdentifier(i) + ","));
            sb.Remove(sb.Length - 1, 1);

            sb.AppendLine(") VALUES (");

            colNames.ForEach(i => sb.Append("?,"));
            sb.Remove(sb.Length - 1, 1);

            sb.AppendLine(")");

            var cmd = new OleDbCommand(sb.ToString(), db, tx);
            int counter = 0;
            foreach (var v in values)
            {
                cmd.Parameters.AddWithValue(string.Format("@param{0}", ++counter), v ?? DBNull.Value);
            }

            cmd.ExecuteNonQuery();
        }

        public void RefreshDbStats()
        {
            // do nothing
        }

        public void ExecuteSqlResource(Type type, string scriptResourceNameFormat)
        {
            if (type == null)
                throw new ArgumentNullException("type");
            if (string.IsNullOrEmpty(scriptResourceNameFormat))
                throw new ArgumentNullException("scriptResourceNameFormat");

            var scriptResourceName = String.Format(scriptResourceNameFormat, ConfigName);
            using (var scriptStream = new StreamReader(type.Assembly.GetManifestResourceStream(scriptResourceName)))
            {
                var databaseScript = scriptStream.ReadToEnd();
                foreach (var cmdString in Regex.Split(databaseScript, "\r?\nGO\r?\n").Where(s => !String.IsNullOrEmpty(s)))
                {
                    ExecuteNonQuery(cmdString);
                }
            }
        }

        /// <summary>Not supported.</summary>
        string ISchemaProvider.GetSavedSchema()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.SaveSchema(string schema)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckDatabaseExists(string dbName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckFKConstraintExists(TableRef tblName, string fkName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckTriggerExists(TriggerRef triggerName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckProcedureExists(ProcRef procName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        long ISchemaProvider.CountRows(TableRef tblName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckPositionColumnValidity(TableRef tblName, string fkName, string posName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.RepairPositionColumn(TableRef tblName, string posName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        int ISchemaProvider.GetColumnMaxLength(TableRef tblName, string colName)
        {
            throw new NotImplementedException();
        }

        /// <summary>Not supported.</summary>
        IEnumerable<TableConstraintNamePair> ISchemaProvider.GetFKConstraintNames()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateDatabase(string dbName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateTable(TableRef tbl, IEnumerable<Column> cols)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateTable(TableRef tblName, bool idAsIdentityColumn)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateTable(TableRef tblName, bool idAsIdentityColumn, bool createPrimaryKey)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateColumn(TableRef tblName, string colName, DbType type, int size, int scale, bool isNullable, params DatabaseConstraint[] constraints)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.AlterColumn(TableRef tblName, string colName, DbType type, int size, int scale, bool isNullable, params DatabaseConstraint[] constraints)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateFKConstraint(TableRef tblName, TableRef refTblName, string colName, string newConstraintName, bool onDeleteCascade)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropTable(TableRef tblName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.TruncateTable(TableRef tblName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropColumn(TableRef tblName, string colName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropDatabase(string dbName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropFKConstraint(TableRef tblName, string constraintName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropTrigger(TriggerRef triggerName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropView(TableRef viewName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropProcedure(ProcRef procName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropAllObjects()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckIndexExists(TableRef tblName, string idxName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropIndex(TableRef tblName, string idxName)
        {
            throw new NotSupportedException();
        }

        void ISchemaProvider.RenameIndex(TableRef tblName, string oldIdxName, string newIdxName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateIndex(TableRef tblName, string idxName, bool unique, bool clustered, params string[] columns)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateUpdateRightsTrigger(TriggerRef triggerName, TableRef tblName, List<RightsTrigger> tblList, List<string> dependingCols)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateEmptyRightsViewUnmaterialized(TableRef viewName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateRightsViewUnmaterialized(TableRef viewName, TableRef tblName, TableRef tblNameRights, IList<ACL> acls)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateRefreshRightsOnProcedure(ProcRef procName, TableRef viewUnmaterializedName, TableRef tblName, TableRef tblNameRights)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.ExecRefreshRightsOnProcedure(ProcRef procName)
        {
            throw new NotSupportedException();
        }

        void ISchemaProvider.CreateRefreshAllRightsProcedure(List<ProcRef> refreshProcNames)
        {
            throw new NotSupportedException();
        }

        void ISchemaProvider.ExecRefreshAllRightsProcedure()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreatePositionColumnValidCheckProcedures(ILookup<TableRef, KeyValuePair<TableRef, string>> refSpecs)
        {
            throw new NotSupportedException();
        }

        void ISchemaProvider.CreateSequenceNumberProcedure()
        {
            throw new NotSupportedException();
        }

        void ISchemaProvider.CreateContinuousSequenceNumberProcedure()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.RenameTable(TableRef oldTblName, TableRef newTblName)
        {
            throw new NotSupportedException();
        }

        void ISchemaProvider.RenameDiscriminatorValue(TableRef tblName, string oldValue, string newValue)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.RenameColumn(TableRef tblName, string oldColName, string newColName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.RenameFKConstraint(TableRef tblName, string oldConstraintName, TableRef refTblName, string colName, string newConstraintName, bool onDeleteCascade)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not implemented.</summary>
        string ISchemaProvider.DbTypeToNative(DbType type)
        {
            throw new NotImplementedException();
        }

        /// <summary>Not implemented.</summary>
        DbType ISchemaProvider.NativeToDbType(string type)
        {
            throw new NotImplementedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.GetHasColumnDefaultValue(TableRef tblName, string colName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.EnsureInfrastructure()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckSchemaExists(string schemaName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        IEnumerable<string> ISchemaProvider.GetSchemaNames()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateSchema(string schemaName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropSchema(string schemaName, bool force)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        ProcRef ISchemaProvider.GetFunctionName(string schemaName, string funcName)
        {
            throw new NotImplementedException();
        }

        /// <summary>Not supported.</summary>
        IEnumerable<ProcRef> ISchemaProvider.GetFunctionNames()
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckFunctionExists(ProcRef funcName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropFunction(ProcRef funcName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DblinkConnect(TableRef tblNamE)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckIndexPossible(TableRef tblName, string idxName, bool unique, bool clustered, params string[] columns)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckCheckConstraintPossible(TableRef tblName, string colName, string newConstraintName, Dictionary<List<string>, Expression<Func<string, bool>>> checkExpression)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.CreateCheckConstraint(TableRef tblName, string colName, string newConstraintName, Dictionary<List<string>, Expression<Func<string, bool>>> checkExpression)
        {
            throw new NotSupportedException();
        }

        bool ISchemaProvider.CheckCheckConstraintExists(TableRef tblName, string constraintName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.DropCheckConstraint(TableRef tblName, string constraintName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        bool ISchemaProvider.CheckTableContainsData(TableRef tblName, IEnumerable<string> discriminatorFilter)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.WriteDefaultValue(TableRef tblName, string colName, object value)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.WriteDefaultValue(TableRef tblName, string colName, object value, IEnumerable<string> discriminatorFilter)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.WriteGuidDefaultValue(TableRef tblName, string colName)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.WriteGuidDefaultValue(TableRef tblName, string colName, IEnumerable<string> discriminatorFilter)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        void ISchemaProvider.MapColumnData(TableRef srcTblName, string[] srcColNames, TableRef tblName, string[] colNames, Dictionary<object, object>[] mappings)
        {
            throw new NotSupportedException();
        }

        /// <summary>Not supported.</summary>
        IEnumerable<TriggerRef> ISchemaProvider.GetTriggerNames()
        {
            throw new NotSupportedException();
        }

        private static readonly object _MappingDefaultSourceValue = new object();
        public object MappingDefaultSourceValue { get { return _MappingDefaultSourceValue; } }
    }
}