
namespace Kistl.Server.SchemaManagement.SqlProvider
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.API.Configuration;
    using Kistl.API.Server;
    using Kistl.API.Utils;

    public class SqlServer
        : ISchemaProvider
    {
        private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Kistl.Server.Schema.MSSQL");
        private readonly static log4net.ILog QueryLog = log4net.LogManager.GetLogger("Kistl.Server.Schema.MSSQL.Queries");

        protected SqlConnection db;
        protected SqlTransaction tx;

        public SqlServer()
        {
            var connectionString = ApplicationContext.Current.Configuration.Server.ConnectionString;
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new ConfigurationException("Configuration/Server/ConnectionString empty, cannot connect to database");
            }
            db = new SqlConnection(connectionString);
            db.Open();
        }

        public void BeginTransaction()
        {
            if (tx != null) throw new InvalidOperationException("Transaction is already running");
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

        private string GetSqlTypeString(System.Data.DbType type)
        {
            switch (type)
            {
                case System.Data.DbType.Int32:
                    return "int";
                case System.Data.DbType.Double:
                    return "float";
                case System.Data.DbType.String:
                    return "nvarchar";
                case System.Data.DbType.Date:
                    return "datetime";
                case System.Data.DbType.DateTime:
                    return "datetime";
                case System.Data.DbType.Boolean:
                    return "bit";
                case System.Data.DbType.Guid:
                    return "uniqueidentifier";
                default:
                    throw new ArgumentOutOfRangeException("type", string.Format("Unable to convert type '{0}' to an sql type string", type));
            }
        }

        public string GetSavedSchema()
        {
            if (!CheckTableExists("CurrentSchema")) return string.Empty;

            int count = CheckVersionCount();
            if (count == 0)
            {
                return String.Empty;
            }

            using (var versionCmd = new SqlCommand("SELECT [Schema] FROM CurrentSchema", db, tx))
            {
                QueryLog.Debug(versionCmd.CommandText);
                return (string)versionCmd.ExecuteScalar();
            }
        }

        private int CheckVersionCount()
        {
            using (var schemaCountCmd = new SqlCommand("SELECT COUNT(*) FROM CurrentSchema", db, tx))
            {
                QueryLog.Debug(schemaCountCmd.CommandText);
                var count = (int)schemaCountCmd.ExecuteScalar();
                if (count > 1)
                {
                    throw new InvalidOperationException("There is more then one Schema saved in your Database");
                }
                return count;
            }
        }

        /// <summary>
        /// TODO: Was ist die Version?
        /// </summary>
        /// <param name="schema"></param>
        public void SaveSchema(string schema)
        {
            if (!CheckTableExists("CurrentSchema")) throw new InvalidOperationException("Unable to save Schema. Schematable does not exist.");

            using (Log.DebugTraceMethodCall("Saving schema"))
            {
                int count = CheckVersionCount();
                string commandString = count == 0
                    ? "INSERT INTO [CurrentSchema] ([Version], [Schema]) VALUES(1, @schema)"
                    : "UPDATE [CurrentSchema] SET [Schema] = @schema, [Version] = [Version] + 1";

                using (var cmd = new SqlCommand(commandString, db, tx))
                {
                    cmd.Parameters.AddWithValue("@schema", schema);
                    QueryLog.Debug(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool CheckTableExists(string tblName)
        {
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(@table) AND type IN (N'U')", db, tx))
            {
                cmd.Parameters.AddWithValue("@table", tblName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckColumnExists(string tblName, string colName)
        {
            using (var cmd = new SqlCommand(@"SELECT COUNT(*) FROM sys.objects o INNER JOIN sys.columns c ON c.object_id=o.object_id
	                                            WHERE o.object_id = OBJECT_ID(@table) 
		                                            AND o.type IN (N'U')
		                                            AND c.Name = @column", db, tx))
            {
                cmd.Parameters.AddWithValue("@table", tblName);
                cmd.Parameters.AddWithValue("@column", colName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckFKConstraintExists(string fkName)
        {
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(@fk_constraint) AND type IN (N'F')", db, tx))
            {
                cmd.Parameters.AddWithValue("@fk_constraint", fkName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckViewExists(string viewName)
        {
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(@view) AND type IN (N'V')", db, tx))
            {
                cmd.Parameters.AddWithValue("@view", viewName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckTriggerExists(string objName, string triggerName)
        {
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(@trigger) AND parent_object_id = OBJECT_ID(@parent) AND type IN (N'TR')", db, tx))
            {
                cmd.Parameters.AddWithValue("@trigger", triggerName);
                cmd.Parameters.AddWithValue("@parent", objName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckProcedureExists(string procName)
        {
            using (var cmd = new SqlCommand("SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(@proc) AND type IN (N'P')", db, tx))
            {
                cmd.Parameters.AddWithValue("@proc", procName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckTableContainsData(string tblName)
        {
            using (var cmd = new SqlCommand(string.Format("SELECT COUNT(*) FROM [{0}]", tblName), db, tx))
            {
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool CheckColumnContainsNulls(string tblName, string colName)
        {
            using (var cmd = new SqlCommand(string.Format("SELECT COUNT(*) FROM [{0}] WHERE [{1}] IS NULL", tblName, colName), db, tx))
            {
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool GetIsColumnNullable(string tblName, string colName)
        {
            using (var cmd = new SqlCommand(@"SELECT c.is_nullable FROM sys.objects o INNER JOIN sys.columns c ON c.object_id=o.object_id
	                                            WHERE o.object_id = OBJECT_ID(@table) 
		                                            AND o.type IN (N'U')
		                                            AND c.Name = @column", db, tx))
            {
                cmd.Parameters.AddWithValue("@table", tblName);
                cmd.Parameters.AddWithValue("@column", colName);
                QueryLog.Debug(cmd.CommandText);
                return (bool)cmd.ExecuteScalar();
            }
        }

        public int GetColumnMaxLength(string tblName, string colName)
        {
            // / 2 -> nvarchar!
            using (var cmd = new SqlCommand(@"SELECT c.max_length / 2 FROM sys.objects o INNER JOIN sys.columns c ON c.object_id=o.object_id
	                                            WHERE o.object_id = OBJECT_ID(@table) 
		                                            AND o.type IN (N'U')
		                                            AND c.Name = @column", db, tx))
            {
                cmd.Parameters.AddWithValue("@table", tblName);
                cmd.Parameters.AddWithValue("@column", colName);
                QueryLog.Debug(cmd.CommandText);
                return (int)cmd.ExecuteScalar();
            }
        }

        public IEnumerable<string> GetTableNames()
        {
            string sqlQuery = "SELECT name FROM sys.objects WHERE type IN (N'U') AND name <> 'sysdiagrams'";
            QueryLog.Debug(sqlQuery);

            using (var cmd = new SqlCommand(sqlQuery, db, tx))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read()) yield return rd.GetString(0);
            }
        }

        public IEnumerable<TableConstraintNamePair> GetFKConstraintNames()
        {
            string sqlQuery = "SELECT c.name, t.name FROM sys.objects c inner join sys.sysobjects t  on t.id = c.parent_object_id WHERE c.type IN (N'F') order by c.name";
            QueryLog.Debug(sqlQuery);

            using (var cmd = new SqlCommand(sqlQuery, db, tx))
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read()) yield return new TableConstraintNamePair() { ConstraintName = rd.GetString(0), TableName = rd.GetString(1) };
            }
        }

        public IEnumerable<string> GetTableColumnNames(string tblName)
        {
            using (var cmd = new SqlCommand(@"SELECT c.name
                                FROM sys.objects o 
                                    INNER JOIN sys.columns c ON c.object_id=o.object_id
	                            WHERE o.object_id = OBJECT_ID(@table) 
		                            AND o.type IN (N'U')", db, tx))
            {
                cmd.Parameters.AddWithValue("@table", tblName);
                QueryLog.Debug(cmd.CommandText);
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read()) yield return rd.GetString(0);
                }
            }
        }

        public void CreateTable(string tblName, bool idAsIdentityColumn)
        {
            CreateTable(tblName, idAsIdentityColumn, true);
        }

        public void CreateTable(string tblName, bool idAsIdentityColumn, bool createPrimaryKey)
        {
            Log.DebugFormat("CreateTable [{0}]", tblName);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CREATE TABLE [{0}] ( ", tblName);
            if (idAsIdentityColumn)
            {
                sb.AppendLine("[ID] [int] IDENTITY(1,1) NOT NULL");
            }
            else
            {
                sb.AppendLine("[ID] [int] NOT NULL");
            }

            if (createPrimaryKey)
            {
                sb.AppendFormat(", CONSTRAINT [PK_{0}] PRIMARY KEY CLUSTERED ( [ID] ASC )", tblName);
            }

            sb.AppendLine();
            sb.Append(")");

            ExecuteNonQuery(sb.ToString());
        }

        public void CreateColumn(string tblName, string colName, System.Data.DbType type, int size, bool isNullable)
        {
            DoColumn(true, tblName, colName, type, size, isNullable);
        }

        public void AlterColumn(string tblName, string colName, System.Data.DbType type, int size, bool isNullable)
        {
            DoColumn(false, tblName, colName, type, size, isNullable);
        }

        private void DoColumn(bool add, string tblName, string colName, System.Data.DbType type, int size, bool isNullable)
        {
            StringBuilder sb = new StringBuilder();

            string addOrAlter = add ? "ADD" : "ALTER COLUMN";
            string nullable = isNullable ? "NULL" : "NOT NULL";

            // TODO: Trick 17, temporäre Lösung
            if (type == System.Data.DbType.String && size > Kistl.API.Helper.Temp_UnlimitedMaxStringLengthLimit)
            {
                Log.DebugFormat("[{0}] table [{1}] column [{2}] ntext [{3}]", addOrAlter, tblName, colName, nullable);
                sb.AppendFormat("ALTER TABLE [{0}] {1} [{2}] {3} {4}", tblName, addOrAlter, colName,
                    "ntext",
                    nullable);
            }
            else
            {
                string typeString = GetSqlTypeString(type) + (size > 0 ? string.Format("({0})", size) : String.Empty);
                Log.DebugFormat("[{0}] table [{1}] column [{2}] [{3}] [{4}]", addOrAlter, tblName, colName, typeString, nullable);
                sb.AppendFormat("ALTER TABLE [{0}] {1}  [{2}] {3} {4}", tblName, addOrAlter, colName,
                    typeString,
                    nullable);
            }

            ExecuteNonQuery(sb.ToString());
        }


        public void CreateFKConstraint(string tblName, string refTblName, string colName, string constraintName, bool onDeleteCascade)
        {
            Log.DebugFormat("Creating foreign key constraint [{0}].[{1}] -> [{2}].ID", tblName, colName, refTblName);
            ExecuteNonQuery(@"ALTER TABLE [{0}]  WITH CHECK 
                    ADD CONSTRAINT [{1}] FOREIGN KEY([{2}])
                    REFERENCES [{3}] ([ID]){4}",
                   tblName,
                   constraintName,
                   colName,
                   refTblName,
                   onDeleteCascade ? @" ON DELETE CASCADE" : String.Empty);

            ExecuteNonQuery(@"ALTER TABLE [{0}] CHECK CONSTRAINT [{1}]",
                   tblName,
                   constraintName);
        }

        public void DropTable(string tblName)
        {
            Log.DebugFormat("Dropping table [{0}]", tblName);
            ExecuteNonQuery("DROP TABLE [{0}]", tblName);
        }

        private void ExecuteNonQuery(string nonQueryFormat, params object[] args)
        {
            string query = String.Format(nonQueryFormat, args);

            using (var cmd = new SqlCommand(query, db, tx))
            {
                QueryLog.Debug(query);
                cmd.ExecuteNonQuery();
            }
        }

        public void DropColumn(string tblName, string colName)
        {
            Log.DebugFormat("Dropping column [{0}].[{1}]", tblName, colName);
            ExecuteNonQuery("ALTER TABLE [{0}] DROP COLUMN [{1}]", tblName, colName);
        }

        public void DropFKConstraint(string tblName, string fkName)
        {
            Log.DebugFormat("Dropping foreign key constraint [{0}].[{1}]", tblName, fkName);
            ExecuteNonQuery("ALTER TABLE [{0}] DROP CONSTRAINT [{1}]", tblName, fkName);
        }

        public void DropTrigger(string triggerName)
        {
            Log.DebugFormat("Dropping trigger [{0}].[{1}]", triggerName);
            ExecuteNonQuery("DROP TRIGGER [{0}]", triggerName);
        }

        public void DropView(string viewName)
        {
            Log.DebugFormat("Dropping view [{0}].[{1}]", viewName);
            ExecuteNonQuery("DROP VIEW [{0}]", viewName);
        }

        public void DropProcedure(string procName)
        {
            Log.DebugFormat("Dropping procedure [{0}].[{1}]", procName);
            ExecuteNonQuery("DROP PROCEDURE [{0}]", procName);
        }

        public void CopyColumnData(string srcTblName, string srcColName, string tblName, string colName)
        {
            Log.DebugFormat("Copying data from [{0}].[{1}] to [{2}].[{3}]", srcTblName, srcColName, tblName, colName);
            ExecuteNonQuery("UPDATE dest SET dest.[{0}] = src.[{1}] FROM [{2}] dest INNER JOIN [{3}] src ON dest.ID = src.ID",
                colName, srcColName, tblName, srcTblName);
        }

        public void CreateIndex(string tblName, string idxName, bool unique, bool clustered, params string[] columns)
        {
            string colSpec = string.Join(", ", columns.Select(c => "[" + c + "]").ToArray());

            Log.DebugFormat("Creating index [{0}].[{1}] ({2})", tblName, idxName, colSpec);

            ExecuteNonQuery("CREATE {0} {1} INDEX {2} ON [{3}] ({4})",
                unique ? "UNIQUE" : string.Empty,
                clustered ? "CLUSTERED" : string.Empty,
                idxName,
                tblName,
                colSpec);
        }

        public void CreateUpdateRightsTrigger(string triggerName, string viewUnmaterializedName, string tblName, string tblNameRights)
        {
            Log.DebugFormat("Creating trigger to update rights for [{0}]", tblName);
            ExecuteNonQuery(@"CREATE TRIGGER [{0}]
                    ON [{1}]
                    AFTER UPDATE, INSERT AS
                    BEGIN
	                    DELETE FROM [{2}] WHERE [ID] IN (SELECT [ID] FROM inserted)
	                    INSERT INTO [{2}] ([ID], [Identity], [Right]) SELECT [ID], [Identity], [Right] FROM [{3}] WHERE [ID] IN (SELECT [ID] FROM inserted)
                    END",
                triggerName,
                tblName,
                tblNameRights,
                viewUnmaterializedName);
        }

        public void CreateRightsViewUnmaterialized(string viewName, string tblName, string tblNameRights)
        {
            Log.DebugFormat("Creating unmaterialized rights view for [{0}]", tblName);
            ExecuteNonQuery(@"CREATE VIEW [{0}] AS
	                SELECT tbl.[ID] [ID], id.ID [Identity], 0 [Right]
	                FROM [{1}] tbl
	                CROSS JOIN Identities id",
                viewName,
                tblName);
        }

        public void CreateRefreshRightsOnProcedure(string procName, string viewUnmaterializedName, string tblName, string tblNameRights)
        {
            Log.DebugFormat("Creating refresh rights procedure for [{0}]", tblName);
            ExecuteNonQuery(@"CREATE PROCEDURE [{0}] (@ID INT = NULL) AS
                    BEGIN
	                    IF (@ID IS NULL)
		                    BEGIN
			                    TRUNCATE TABLE [{1}]
			                    INSERT INTO [{1}] ([ID], [Identity], [Right]) SELECT [ID], [Identity], [Right] FROM [{2}]
		                    END
	                    ELSE
		                    BEGIN
			                    DELETE FROM [{1}] WHERE ID = @ID
			                    INSERT INTO [{1}] ([ID], [Identity], [Right]) SELECT [ID], [Identity], [Right] FROM [{2}] WHERE [ID] = @ID
		                    END
                    END",
                procName,
                tblNameRights,
                viewUnmaterializedName);
        }
    }
}
