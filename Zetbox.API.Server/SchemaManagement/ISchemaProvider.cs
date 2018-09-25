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

namespace Zetbox.API.Server
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data;
    using System.Diagnostics;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    public abstract class DboRef : IComparable<DboRef>, IComparable
    {
        private readonly string _database;

        /// <summary>
        /// The database containing this database object.
        /// </summary>
        public string Database { get { return _database; } }

        private readonly string _schema;

        /// <summary>
        /// The database schema containing this database object.
        /// </summary>
        public string Schema { get { return _schema; } }

        private readonly string _name;

        /// <summary>
        /// The name of the database object.
        /// </summary>
        public string Name { get { return _name; } }

        protected DboRef(string database, string schema, string name)
        {
            _database = database;
            _schema = schema;
            _name = name;
        }

        public override string ToString()
        {
            return String.Format("Ref: '{0}'.'{1}'.'{2}'", _database, _schema, _name);
        }

        public override int GetHashCode()
        {
            return (_database + _schema + _name).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            var other = obj as DboRef;

            if (other == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this == other;
        }

        int IComparable<DboRef>.CompareTo(DboRef other)
        {
            if (other == null)
                return -1;

            var type = this.GetType().AssemblyQualifiedName.CompareTo(other.GetType().AssemblyQualifiedName);
            if (type != 0)
                return type;

            var db = String.Compare(_database, other._database);
            if (db != 0)
                return db;

            var sc = String.Compare(_schema, other._schema);
            if (sc != 0)
                return sc;

            return String.Compare(_name, other._name);
        }

        // only needed for NUnit (and other legacy APIs)
        int IComparable.CompareTo(object obj)
        {
            var other = obj as DboRef;
            return ((IComparable<DboRef>)this).CompareTo(other);
        }

        public static bool operator ==(DboRef x, DboRef y)
        {
            if (!object.ReferenceEquals(x, null) && !object.ReferenceEquals(y, null))
            {
                return x.GetType().Equals(y.GetType())
                    && x._database == y._database
                    && x._schema == y._schema
                    && x._name == y._name;
            }
            else
            {
                return object.ReferenceEquals(x, null) && object.ReferenceEquals(y, null);
            }
        }

        public static bool operator !=(DboRef x, DboRef y)
        {
            return !(x == y);
        }

        public static bool operator >(DboRef x, DboRef y)
        {
            if (x == null)
                throw new ArgumentNullException("x");
            return ((IComparable<DboRef>)x).CompareTo(y) > 0;
        }

        public static bool operator <(DboRef x, DboRef y)
        {
            if (x == null)
                throw new ArgumentNullException("x");
            return ((IComparable<DboRef>)x).CompareTo(y) < 0;
        }
    }

    public sealed class TableRef : DboRef, IComparable<TableRef>, ICloneable
    {
        public TableRef(string database, string schema, string name)
            : base(database, schema, name)
        {
        }

        int IComparable<TableRef>.CompareTo(TableRef other)
        {
            return ((IComparable<DboRef>)this).CompareTo(other);
        }

        public static bool operator ==(TableRef x, TableRef y)
        {
            return ((DboRef)x) == ((DboRef)y);
        }
        public static bool operator !=(TableRef x, TableRef y)
        {
            return ((DboRef)x) != ((DboRef)y);
        }
        public static bool operator >(TableRef x, TableRef y)
        {
            return ((DboRef)x) > ((DboRef)y);
        }
        public static bool operator <(TableRef x, TableRef y)
        {
            return ((DboRef)x) < ((DboRef)y);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        object ICloneable.Clone()
        {
            return new TableRef(Database, Schema, Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public sealed class ProcRef : DboRef, IComparable<ProcRef>, ICloneable
    {
        public ProcRef(string database, string schema, string name)
            : base(database, schema, name)
        {
        }

        int IComparable<ProcRef>.CompareTo(ProcRef other)
        {
            return ((IComparable<DboRef>)this).CompareTo(other);
        }

        public static bool operator ==(ProcRef x, ProcRef y)
        {
            return ((DboRef)x) == ((DboRef)y);
        }
        public static bool operator !=(ProcRef x, ProcRef y)
        {
            return ((DboRef)x) != ((DboRef)y);
        }
        public static bool operator >(ProcRef x, ProcRef y)
        {
            return ((DboRef)x) > ((DboRef)y);
        }
        public static bool operator <(ProcRef x, ProcRef y)
        {
            return ((DboRef)x) < ((DboRef)y);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        object ICloneable.Clone()
        {
            return new ProcRef(Database, Schema, Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public sealed class ConstraintRef : DboRef, IComparable<ConstraintRef>, ICloneable
    {
        public ConstraintRef(string database, string schema, string name)
            : base(database, schema, name)
        {
        }

        int IComparable<ConstraintRef>.CompareTo(ConstraintRef other)
        {
            return ((IComparable<DboRef>)this).CompareTo(other);
        }

        public static bool operator ==(ConstraintRef x, ConstraintRef y)
        {
            return ((DboRef)x) == ((DboRef)y);
        }
        public static bool operator !=(ConstraintRef x, ConstraintRef y)
        {
            return ((DboRef)x) != ((DboRef)y);
        }
        public static bool operator >(ConstraintRef x, ConstraintRef y)
        {
            return ((DboRef)x) > ((DboRef)y);
        }
        public static bool operator <(ConstraintRef x, ConstraintRef y)
        {
            return ((DboRef)x) < ((DboRef)y);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        object ICloneable.Clone()
        {
            return new ConstraintRef(Database, Schema, Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public sealed class TriggerRef : DboRef, IComparable<TriggerRef>, ICloneable
    {
        public TriggerRef(string database, string schema, string name)
            : base(database, schema, name)
        {
        }

        public TriggerRef(TableRef tblName, string name)
            : base(tblName != null ? tblName.Database : null, tblName != null ? tblName.Schema : null, name)
        {
        }

        int IComparable<TriggerRef>.CompareTo(TriggerRef other)
        {
            return ((IComparable<DboRef>)this).CompareTo(other);
        }

        public static bool operator ==(TriggerRef x, TriggerRef y)
        {
            return ((DboRef)x) == ((DboRef)y);
        }
        public static bool operator !=(TriggerRef x, TriggerRef y)
        {
            return ((DboRef)x) != ((DboRef)y);
        }
        public static bool operator >(TriggerRef x, TriggerRef y)
        {
            return ((DboRef)x) > ((DboRef)y);
        }
        public static bool operator <(TriggerRef x, TriggerRef y)
        {
            return ((DboRef)x) < ((DboRef)y);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }


        object ICloneable.Clone()
        {
            return new TriggerRef(Database, Schema, Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class TableConstraintNamePair
    {
        public TableRef TableName { get; set; }
        public string ConstraintName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", TableName, ConstraintName);
        }
    }

    public class ACL
    {
        public ACL()
        {
            this.Relations = new List<Join>();
        }

        public AccessRights Right { get; set; }
        public List<Join> Relations { get; private set; }
    }

    public enum JoinType
    {
        Inner = 0,
        Left,
    }

    /// <summary>
    /// Represents a Join Operation between two Tables
    /// </summary>
    public class Join
    {
        /// <summary>
        /// The Table to join
        /// </summary>
        public TableRef JoinTableName { get; set; }
        /// <summary>
        /// The Columns to join in the referenced table
        /// </summary>
        public ColumnRef[] JoinColumnName { get; set; }
        /// <summary>
        /// The own FK-Columns
        /// </summary>
        public ColumnRef[] FKColumnName { get; set; }
        /// <summary>
        /// Type of Join
        /// </summary>
        public JoinType Type { get; set; }
        /// <summary>
        /// Whether or not this join treats nulls as equal.
        ///
        /// By default, SQL treats comparisons to null as null, but in some special cases, we want to treat null as equal to null. Set this property to true to do so.
        /// </summary>
        public bool[] CompareNullsAsEqual { get; set; }

        private List<Join> _joins = null;
        public List<Join> Joins
        {
            get
            {
                if (_joins == null)
                {
                    _joins = new List<Join>();
                }
                return _joins;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "{0}JOIN {1} ON (({2}) = ({3}))",
                Type == JoinType.Left ? "LEFT " : String.Empty,
                JoinTableName,
                String.Join(", ", JoinColumnName.Select(cr => cr.ToString()).ToArray()),
                String.Join(", ", FKColumnName.Select(cr => cr.ToString()).ToArray()));
        }
    }

    public class ColumnRef
    {
        private class LocalJoin : Join
        {
            public override string ToString()
            {
                return "Local Join";
            }
        }
        private class PrimaryJoin : Join
        {
            public override string ToString()
            {
                return "Primary Table Join";
            }
        }
        public static readonly Join Local = new LocalJoin();
        public static readonly Join PrimaryTable = new PrimaryJoin();

        public ColumnRef()
        {
        }

        public ColumnRef(string name, Join source)
            : this(name, source, null)
        {
        }

        public ColumnRef(string name, Join source, DbType? colType)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            if (source == null)
                throw new ArgumentNullException("source");

            this.ColumnName = name;
            this.Source = source;
            this.Type = colType;
        }

        public string ColumnName { get; private set; }
        public Join Source { get; private set; }
        public DbType? Type { get; private set; }

        public override string ToString()
        {
            return string.Format("CR: {0}{1}", Source != PrimaryTable ? "." + Source : string.Empty, ColumnName);
        }
    }

    public class ProjectionColumn : ColumnRef
    {
        public ProjectionColumn(string name, Join source, string alias)
            : this(name, source, null, alias, null)
        {
        }

        public ProjectionColumn(string name, Join source, string alias, string nullValue)
            : this(name, source, null, alias, nullValue)
        {
        }

        public ProjectionColumn(string name, Join source, DbType? colType, string alias)
            : this(name, source, colType, alias, null)
        {
        }

        public ProjectionColumn(string name, Join source, DbType? colType, string alias, string nullValue)
            : base(name, source, colType)
        {
            if (alias == String.Empty)
                throw new ArgumentNullException("alias");

            this.Alias = alias;
            this.NullValue = nullValue;
        }

        public string Alias { get; private set; }
        public string NullValue { get; private set; }

        public override string ToString()
        {
            return string.Format("PC: {0}{1}", Source == PrimaryTable ? PrimaryTable.ToString() : "." + Source, ColumnName);
        }
    }

    public class RightsTrigger
    {
        public RightsTrigger()
        {
            this.ObjectRelations = new List<Join>();
            this.IdentityRelations = new List<Join>();
        }

        public TableRef ViewUnmaterializedName { get; set; }
        public TableRef TblNameRights { get; set; }
        public TableRef TblName { get; set; }

        public List<Join> ObjectRelations { get; private set; }
        public List<Join> IdentityRelations { get; private set; }
    }

    public class Column
    {
        public string Name { get; set; }
        public DbType Type { get; set; }
        public int Size { get; set; }
        public int? Scale { get; set; }
        public bool IsNullable { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}({2}{3}) {3}",
                Name,
                Type,
                Size,
                Scale.HasValue ? ", " + Scale.Value.ToString() : String.Empty,
                IsNullable ? "NULL" : "NOT NULL");
        }
    }

    public abstract class DatabaseConstraint
    {
        public static readonly DatabaseConstraint[] EmptyArray = new DatabaseConstraint[] { };
    }

    public abstract class DefaultConstraint : DatabaseConstraint
    {
    }

    public class IntDefaultConstraint : DefaultConstraint
    {
        public int Value { get; set; }
    }

    public class DecimalDefaultConstraint : DefaultConstraint
    {
        public decimal Value { get; set; }
    }

    public class BoolDefaultConstraint : DefaultConstraint
    {
        public bool Value { get; set; }
    }

    public class StringDefaultConstraint : DefaultConstraint
    {
        public string Value { get; set; }
    }

    public class NewGuidDefaultConstraint : DefaultConstraint
    {
    }

    public enum DateTimeDefaultConstraintPrecision
    {
        Date,
        Time,
    }

    public class DateTimeDefaultConstraint : DefaultConstraint
    {
        public DateTimeDefaultConstraintPrecision Precision { get; set; }
    }

    public abstract class CheckConstraint : DatabaseConstraint
    {
    }

    public class BoolCheckConstraint : CheckConstraint
    {
        public bool Value { get; set; }
    }

    public interface ISchemaProvider : IDisposable
    {
        #region Meta data

        string ConfigName { get; }
        string AdoNetProvider { get; }
        string ManifestToken { get; }
        /// <summary>
        /// Returns true if this ISchemaProvider implementation can be used as Zetbox Storage provider.
        /// Currently only SqlServer and Postgres are supported. OleDb is only capable of providing functionality
        /// for Data/Schema migration.
        /// </summary>
        bool IsStorageProvider { get; }

        #endregion

        #region Connection and Transaction Handling

        void Open(string connectionString);
        void Close();

        /// <summary>
        /// Gets a copy of the connection string for the currently open connection, safe for logging. That is, without any sensitive credential information.
        /// </summary>
        /// <returns></returns>
        string GetSafeConnectionString();

        /// <summary>
        /// Gets a copy of the connection string, safe for logging. That is, without any sensitive credential information.
        /// </summary>
        /// <returns></returns>
        string GetSafeConnectionString(string connectionString);

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
        void DblinkConnect(TableRef tblName);

        #endregion

        #region Type Mapping and string handling

        string DbTypeToNative(DbType type);
        DbType NativeToDbType(string type);

        string QuoteIdentifier(string name);
        #endregion

        #region Database Management

        /// <summary>
        /// Checks whether the specified database exists.
        /// </summary>
        /// <param name="dbName">the name of the database</param>
        /// <returns>true if the database exists, false otherwise</returns>
        bool CheckDatabaseExists(string dbName);

        /// <summary>
        /// Creates the specified database with default parameters.
        /// </summary>
        /// <param name="dbName">the name of the database</param>
        void CreateDatabase(string dbName);

        /// <summary>
        /// Deletes the specified database
        /// </summary>
        /// <param name="dbName">the name of the database</param>
        void DropDatabase(string dbName);

        #endregion

        #region Database Schemas

        bool CheckSchemaExists(string schemaName);
        IEnumerable<string> GetSchemaNames();
        void CreateSchema(string schemaName);
        void DropSchema(string schemaName, bool force);

        #endregion

        #region Table Structure

        TableRef GetTableName(string schemaName, string tblName);

        bool CheckTableExists(TableRef tblName);
        IEnumerable<TableRef> GetTableNames();

        void CreateTable(TableRef tblName, IEnumerable<Column> cols);
        void CreateTable(TableRef tblName, bool idAsIdentityColumn);
        void CreateTable(TableRef tblName, bool idAsIdentityColumn, bool createPrimaryKey);

        /// <summary>
        /// Renames the given object. The provider has to detect noop's. The provider must throw an exception, when the object was not found
        /// </summary>
        /// <param name="oldTblName"></param>
        /// <param name="newTblName"></param>
        void RenameTable(TableRef oldTblName, TableRef newTblName);
        void DropTable(TableRef tblName);

        void RenameDiscriminatorValue(TableRef tblName, string oldValue, string newValue);

        bool CheckColumnExists(TableRef tblName, string colName);
        IEnumerable<string> GetTableColumnNames(TableRef tblName);
        IEnumerable<Column> GetTableColumns(TableRef tblName);

        void CreateColumn(TableRef tblName, string colName, DbType type, int size, int scale, bool isNullable, params DatabaseConstraint[] constraints);
        void AlterColumn(TableRef tblName, string colName, DbType type, int size, int scale, bool isNullable, params DatabaseConstraint[] constraints);

        /// <summary>
        /// Renames the given object. The provider has to detect noop's. The provider must throw an exception, when the object was not found
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="oldColName"></param>
        /// <param name="newColName"></param>
        void RenameColumn(TableRef tblName, string oldColName, string newColName);

        bool GetIsColumnNullable(TableRef tblName, string colName);
        bool GetHasColumnDefaultValue(TableRef tblName, string colName);
        int GetColumnMaxLength(TableRef tblName, string colName);

        void DropColumn(TableRef tblName, string colName);

        #endregion

        #region Table Content

        bool CheckTableContainsData(TableRef tblName);
        bool CheckTableContainsData(TableRef tblName, IEnumerable<string> discriminatorFilter);
        bool CheckColumnContainsNulls(TableRef tblName, string colName);
        bool CheckFKColumnContainsUniqueValues(TableRef tblName, string colName);
        bool CheckColumnContainsValues(TableRef tblName, string colName);
        long CountRows(TableRef tableRef);

        void TruncateTable(TableRef tblName);

        /// <summary>
        /// Batch-copies column data from srcTblName.srcColName to tblName.colName, matching rows on "ID" column.
        /// </summary>
        void CopyColumnData(TableRef srcTblName, string srcColName, TableRef tblName, string colName);

        /// <summary>
        /// Batch-copies column data from srcTblName.srcColName[i] to tblName.colName[i], matching rows on "ID" column. When discriminatorValue is not null, the TableMapper.DiscriminatorColumnName is set to this value.
        /// </summary>
        /// <remarks>discriminatorValue is introduced specifically for TPT&gt;-&lt;TPH migrations.</remarks>
        void CopyColumnData(TableRef srcTblName, string[] srcColNames, TableRef tblName, string[] colNames, string discriminatorValue = null);

        /// <summary>
        /// Maps the srcColNames from srcTableName to the corresponding colNames in tblName, translating each value by the specified mappings.
        /// </summary>
        void MapColumnData(TableRef srcTblName, string[] srcColNames, TableRef tblName, string[] colNames, Dictionary<object, object>[] mappings);

        /// <summary>
        /// Use this value in MapColumnData mappings as source value for the mapping when no other value has matched.
        /// </summary>
        object MappingDefaultSourceValue { get; }

        #endregion

        #region Constraint and Index Management

        bool CheckFKConstraintExists(TableRef tblName, string fkName);
        IEnumerable<TableConstraintNamePair> GetFKConstraintNames();
        void CreateFKConstraint(TableRef tblName, TableRef refTblName, string colName, string newConstraintName, bool onDeleteCascade);
        /// <summary>
        /// Renames the given object. The provider has to detect noop's. The provider must throw an exception, when the object was not found
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="oldConstraintName"></param>
        /// <param name="refTblName"></param>
        /// <param name="colName"></param>
        /// <param name="newConstraintName"></param>
        /// <param name="onDeleteCascade"></param>
        void RenameFKConstraint(TableRef tblName, string oldConstraintName, TableRef refTblName, string colName, string newConstraintName, bool onDeleteCascade);
        void DropFKConstraint(TableRef tblName, string constraintName);

        bool CheckIndexExists(TableRef tblName, string idxName);
        bool CheckIndexPossible(TableRef tblName, string idxName, bool unique, bool clustered, params string[] columns);
        void CreateIndex(TableRef tblName, string idxName, bool unique, bool clustered, params string[] columns);
        void DropIndex(TableRef tblName, string idxName);
        /// <summary>
        /// Renames the given object. The provider has to detect noop's. The provider must throw an exception, when the object was not found
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="oldIdxName"></param>
        /// <param name="newIdxName"></param>
        void RenameIndex(TableRef tblName, string oldIdxName, string newIdxName);

        /// <summary>
        /// Checks whether a column fulfills certain criteria based on the DiscriminatorColumn
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="colName"></param>
        /// <param name="newConstraintName"></param>
        /// <param name="checkExpressions">A mapping from DiscriminatorColumn values to check Expressions</param>
        /// <returns>true, when all values in the column match the constraint</returns>
        bool CheckCheckConstraintPossible(TableRef tblName, string colName, string newConstraintName, Dictionary<List<string>, Expression<Func<string, bool>>> checkExpressions);

        /// <summary>
        /// Creates a check constraint based on the DiscriminatorColumn values
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="colName"></param>
        /// <param name="newConstraintName"></param>
        /// <param name="checkExpressions">A mapping from DiscriminatorColumn values to check Expressions</param>
        /// <returns></returns>
        void CreateCheckConstraint(TableRef tblName, string colName, string newConstraintName, Dictionary<List<string>, Expression<Func<string, bool>>> checkExpressions);

        /// <summary>
        /// Drops the specified check constraint.
        /// </summary>
        void DropCheckConstraint(TableRef tblName, string constraintName);

        bool CheckCheckConstraintExists(TableRef tblName, string constraintName);

        #endregion

        #region Other DB Objects (Views, Triggers, Procedures)

        IEnumerable<TableRef> GetViewNames();
        bool CheckViewExists(TableRef viewName);
        string GetViewDefinition(TableRef view);
        void DropView(TableRef viewName);

        IEnumerable<TriggerRef> GetTriggerNames();
        bool CheckTriggerExists(TriggerRef triggerName);
        void DropTrigger(TriggerRef triggerName);

        ProcRef GetProcedureName(string schemaName, string procName);
        IEnumerable<ProcRef> GetProcedureNames();
        string GetProcedureDefinition(ProcRef proc);
        bool CheckProcedureExists(ProcRef procName);
        void DropProcedure(ProcRef procName);

        ProcRef GetFunctionName(string schemaName, string funcName);
        IEnumerable<ProcRef> GetFunctionNames();
        bool CheckFunctionExists(ProcRef funcName);
        void DropFunction(ProcRef funcName);

        /// <summary>
        /// Setup schema provider-local structures
        /// </summary>
        void EnsureInfrastructure();
        void DropAllObjects();

        #endregion

        #region Zetbox Schema Handling

        string GetSavedSchema();
        void SaveSchema(string schema);

        #endregion

        #region zetbox Accelerators

        bool CheckPositionColumnValidity(TableRef tblName, string fkName, string posName);
        bool RepairPositionColumn(TableRef tblName, string positionColumnName);

        #endregion

        void MigrateFKs(TableRef srcTblName, string srcColName, TableRef tblName, string colName);
        void InsertFKs(TableRef srcTblName, string srcColName, TableRef tblName, string colName, string fkColName);
        void CopyFKs(TableRef srcTblName, string srcColName, TableRef destTblName, string destColName, string srcFKColName);

        /// <summary>
        /// Creates a trigger updating materialized rights views.
        /// </summary>
        /// <param name="triggerName"></param>
        /// <param name="tblName"></param>
        /// <param name="tblList"></param>
        /// <param name="dependingCols">List of columns triggering a rights update. Typically a list of fk_ cols.</param>
        void CreateUpdateRightsTrigger(TriggerRef triggerName, TableRef tblName, List<RightsTrigger> tblList, List<string> dependingCols);
        void CreateRightsViewUnmaterialized(TableRef viewName, TableRef tblName, TableRef tblNameRights, IList<ACL> acls);
        void CreateEmptyRightsViewUnmaterialized(TableRef viewName);
        void CreateRefreshRightsOnProcedure(ProcRef procName, TableRef viewUnmaterializedName, TableRef tblName, TableRef tblNameRights);
        void ExecRefreshRightsOnProcedure(ProcRef procName);
        void CreateRefreshAllRightsProcedure(List<ProcRef> refreshProcNames);
        void ExecRefreshAllRightsProcedure();

        /// <summary>
        /// Creates a procedure to check position columns for their validity.
        /// </summary>
        /// <param name="refSpecs">a lookup by table name into lists of (referencedTableName, fkColumnName) pairs</param>
        void CreatePositionColumnValidCheckProcedures(ILookup<TableRef, KeyValuePair<TableRef, string>> refSpecs);

        void CreateSequenceNumberProcedure();
        void CreateContinuousSequenceNumberProcedure();

        IDataReader ReadTableData(TableRef tblName, IEnumerable<string> colNames);
        IDataReader ReadTableData(string sql);
        IDataReader ReadJoin(TableRef tblName, IEnumerable<ProjectionColumn> colNames, IEnumerable<Join> joins);

        void WriteTableData(TableRef destTblName, IDataReader source, IEnumerable<string> colNames);
        void WriteTableData(TableRef destTblName, IEnumerable<string> colNames, IEnumerable values);

        void WriteDefaultValue(TableRef tblName, string colName, object value);
        void WriteDefaultValue(TableRef tblName, string colName, object value, IEnumerable<string> discriminatorFilter);
        void WriteGuidDefaultValue(TableRef tblName, string colName);
        void WriteGuidDefaultValue(TableRef tblName, string colName, IEnumerable<string> discriminatorFilter);

        /// <summary>
        /// This can be called after significant changes to the database to cause the DBMS' optimizier to refresh its internal stats.
        /// </summary>
        void RefreshDbStats();

        /// <param name="type">A Type to locate the Resource's Assembly</param>
        /// <param name="scriptResourceNameFormat">the Resource path to locate the SQL script. "{0}" is replaced by the ConfigName.</param>
        void ExecuteSqlResource(Type type, string scriptResourceNameFormat);
    }
}
