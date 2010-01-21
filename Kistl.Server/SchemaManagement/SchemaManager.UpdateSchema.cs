using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators.Extensions;
using Kistl.Server.Generators;
using Kistl.API.Utils;

namespace Kistl.Server.SchemaManagement
{
    public partial class SchemaManager
    {
        public void UpdateSchema()
        {
            using (Log.DebugTraceMethodCall())
            {
                WriteReportHeader("Update Schema Report");

                db.BeginTransaction();
                try
                {
                    UpdateTables();
                    UpdateRelations();
                    UpdateInheritance();

                    UpdateDeletedRelations();
                    UpdateDeletedTables();

                    SaveSchema(schema);

                    db.CommitTransaction();
                }
                catch (Exception ex)
                {
                    db.RollbackTransaction();
                    Log.Debug(String.Empty);
                    Log.Error("An error ocurred while updating the schema", ex);
                    throw;
                }
            }
        }

        private void UpdateDeletedTables()
        {
            Log.Info("Updating deleted Tables");
            Log.Debug("-----------------------");

            foreach (ObjectClass objClass in Case.savedSchema.GetQuery<ObjectClass>().OrderBy(o => o.Module.Namespace).ThenBy(o => o.ClassName))
            {
                Log.DebugFormat("Objectclass: {0}.{1}", objClass.Module.Namespace, objClass.ClassName);
                if (Case.IsDeleteObjectClass(objClass))
                {
                    Case.DoDeleteObjectClass(objClass);
                }
            }
            Log.Debug(String.Empty);
        }


        private void UpdateTables()
        {
            Log.Info("Updating Tables & Columns");
            Log.Debug("-------------------------");

            foreach (ObjectClass objClass in schema.GetQuery<ObjectClass>().OrderBy(o => o.Module.Namespace).ThenBy(o => o.ClassName))
            {
                Log.DebugFormat("Objectclass: {0}.{1}", objClass.Module.Namespace, objClass.ClassName);
                if (Case.IsNewObjectClass(objClass))
                {
                    Case.DoNewObjectClass(objClass);
                }
                if (Case.IsRenameObjectClassTable(objClass))
                {
                    Case.DoRenameObjectClassTable(objClass);
                }
                if (Case.IsNewObjectClassSecurityRules(objClass))
                {
                    Case.DoNewObjectClassSecurityRules(objClass);
                }
                if (Case.IsDeleteObjectClassSecurityRules(objClass))
                {
                    Case.DoDeleteObjectClassSecurityRules(objClass);
                }

                UpdateColumns(objClass, objClass.Properties, String.Empty);
                UpdateDeletedColumns(objClass, String.Empty);
            }
            Log.Debug(String.Empty);
        }

        private void UpdateColumns(ObjectClass objClass, ICollection<Property> properties, string prefix)
        {
            foreach (ValueTypeProperty prop in properties.OfType<ValueTypeProperty>().Where(p => !p.IsList))
            {
                if (Case.IsNewValueTypePropertyNullable(prop))
                {
                    Case.DoNewValueTypePropertyNullable(objClass, prop, prefix);
                }
                if (Case.IsNewValueTypePropertyNotNullable(prop))
                {
                    Case.DoNewValueTypePropertyNotNullable(objClass, prop, prefix);
                }
                if (Case.IsRenameValueTypePropertyName(prop))
                {
                    Case.DoRenameValueTypePropertyName(objClass, prop, prefix);
                }
                if (Case.IsMoveValueTypeProperty(prop))
                {
                    Case.DoMoveValueTypeProperty(objClass, prop, prefix);
                }
                if (Case.IsChangeValueTypeProperty_To_NotNullable(prop))
                {
                    Case.DoChangeValueTypeProperty_To_NotNullable(objClass, prop, prefix);
                }
                if (Case.IsChangeValueTypeProperty_To_Nullable(prop))
                {
                    Case.DoChangeValueTypeProperty_To_Nullable(objClass, prop, prefix);
                }
            }

            foreach (CompoundObjectProperty sprop in properties.OfType<CompoundObjectProperty>().Where(p => !p.IsList))
            {
                UpdateColumns(objClass, sprop.CompoundObjectDefinition.Properties, Construct.NestedColumnName(sprop, prefix));
            }

            foreach (ValueTypeProperty prop in properties.OfType<ValueTypeProperty>().Where(p => p.IsList))
            {
                if (Case.IsNewValueTypePropertyList(prop))
                {
                    Case.DoNewValueTypePropertyList(objClass, prop);
                }
                if (Case.IsRenameValueTypePropertyListName(prop))
                {
                    Case.DoRenameValueTypePropertyListName(objClass, prop);
                }
                if (Case.IsMoveValueTypePropertyList(prop))
                {
                    Case.DoMoveValueTypePropertyList(objClass, prop);
                }
            }

            foreach (CompoundObjectProperty prop in properties.OfType<CompoundObjectProperty>().Where(p => p.IsList))
            {
                if (Case.IsNewCompoundObjectPropertyList(prop))
                {
                    Case.DoNewCompoundObjectPropertyList(objClass, prop);
                }
                if (Case.IsRenameCompoundObjectPropertyListName(prop))
                {
                    Case.DoRenameCompoundObjectPropertyListName(objClass, prop);
                }
                if (Case.IsMoveCompoundObjectPropertyList(prop))
                {
                    Case.DoMoveCompoundObjectPropertyList(objClass, prop);
                }
            }
        }

        private void UpdateDeletedColumns(ObjectClass objClass, string prefix)
        {
            foreach (ValueTypeProperty prop in Case.savedSchema.GetQuery<ValueTypeProperty>().Where(p => p.ObjectClass.ExportGuid == objClass.ExportGuid && !p.IsList))
            {
                if (Case.IsDeleteValueTypeProperty(prop))
                {
                    Case.DoDeleteValueTypeProperty(objClass, prop, prefix);
                }
            }
        }

        private void UpdateDeletedRelations()
        {
            Log.Info("Updating deleted Relations");
            Log.Debug("--------------------------");

            foreach (Relation rel in Case.savedSchema.GetQuery<Relation>().OrderBy(r => r.Module.Namespace))
            {
                Log.DebugFormat("Relation: {0} ({1})", rel.GetAssociationName(), rel.GetRelationType());

                if (rel.GetRelationType() == RelationType.one_n)
                {
                    if (Case.IsDelete_1_N_Relation(rel))
                    {
                        Case.DoDelete_1_N_Relation(rel);
                    }
                }
                else if (rel.GetRelationType() == RelationType.n_m)
                {
                    if (Case.IsDelete_N_M_Relation(rel))
                    {
                        Case.DoDelete_N_M_Relation(rel);
                    }
                }
                else if (rel.GetRelationType() == RelationType.one_one)
                {
                    if (Case.IsDelete_1_1_Relation(rel))
                    {
                        Case.DoDelete_1_1_Relation(rel);
                    }
                }
            }
            Log.Debug(String.Empty);
        }

        private void UpdateRelations()
        {
            Log.Info("Updating Relations");
            Log.Debug("------------------");

            foreach (Relation rel in schema.GetQuery<Relation>().OrderBy(r => r.Module.Namespace))
            {
                Log.DebugFormat("Relation: {0} ({1})", rel.GetAssociationName(), rel.GetRelationType());

                if (rel.GetRelationType() == RelationType.one_n)
                {
                    if (Case.IsNew_1_N_Relation(rel))
                    {
                        Case.DoNew_1_N_Relation(rel);
                    }
                    if (Case.Is_1_N_RelationChange_FromIndexed_To_NotIndexed(rel))
                    {
                        Case.Do_1_N_RelationChange_FromIndexed_To_NotIndexed(rel);
                    }
                    if (Case.Is_1_N_RelationChange_FromNotIndexed_To_Indexed(rel))
                    {
                        Case.Do_1_N_RelationChange_FromNotIndexed_To_Indexed(rel);
                    }
                    if (Case.Is_1_N_RelationChange_FromNullable_To_NotNullable(rel))
                    {
                        Case.Do_1_N_RelationChange_FromNullable_To_NotNullable(rel);
                    }
                    if (Case.Is_1_N_RelationChange_FromNotNullable_To_Nullable(rel))
                    {
                        Case.Do_1_N_RelationChange_FromNotNullable_To_Nullable(rel);
                    }
                }
                else if (rel.GetRelationType() == RelationType.n_m)
                {
                    if (Case.IsNew_N_M_Relation(rel))
                    {
                        Case.DoNew_N_M_Relation(rel);
                    }
                    if (Case.Is_N_M_RelationChange_FromIndexed_To_NotIndexed(rel, RelationEndRole.A))
                    {
                        Case.Do_N_M_RelationChange_FromIndexed_To_NotIndexed(rel, RelationEndRole.A);
                    }
                    if (Case.Is_N_M_RelationChange_FromIndexed_To_NotIndexed(rel, RelationEndRole.B))
                    {
                        Case.Do_N_M_RelationChange_FromIndexed_To_NotIndexed(rel, RelationEndRole.B);
                    }
                    if (Case.Is_N_M_RelationChange_FromNotIndexed_To_Indexed(rel, RelationEndRole.A))
                    {
                        Case.Do_N_M_RelationChange_FromNotIndexed_To_Indexed(rel, RelationEndRole.A);
                    }
                    if (Case.Is_N_M_RelationChange_FromNotIndexed_To_Indexed(rel, RelationEndRole.B))
                    {
                        Case.Do_N_M_RelationChange_FromNotIndexed_To_Indexed(rel, RelationEndRole.B);
                    }
                }
                else if (rel.GetRelationType() == RelationType.one_one)
                {
                    if (Case.IsNew_1_1_Relation(rel))
                    {
                        Case.DoNew_1_1_Relation(rel);
                    }

                    if (Case.Is1_1_RelationChange_FromNotNullable_To_Nullable(rel, RelationEndRole.A))
                    {
                        Case.Do1_1_RelationChange_FromNotNullable_To_Nullable(rel, RelationEndRole.A);
                    }
                    if (Case.Is1_1_RelationChange_FromNotNullable_To_Nullable(rel, RelationEndRole.B))
                    {
                        Case.Do1_1_RelationChange_FromNotNullable_To_Nullable(rel, RelationEndRole.B);
                    }

                    if (Case.Is1_1_RelationChange_FromNullable_To_NotNullable(rel, RelationEndRole.A))
                    {
                        Case.Do1_1_RelationChange_FromNullable_To_NotNullable(rel, RelationEndRole.A);
                    }
                    if (Case.Is1_1_RelationChange_FromNullable_To_NotNullable(rel, RelationEndRole.B))
                    {
                        Case.Do1_1_RelationChange_FromNullable_To_NotNullable(rel, RelationEndRole.B);
                    }
                }
            }
            Log.Debug(String.Empty);
        }

        private void UpdateInheritance()
        {
            Log.Info("Updating Inheritance");
            Log.Debug("--------------------");

            foreach (ObjectClass objClass in schema.GetQuery<ObjectClass>().OrderBy(o => o.Module.Namespace).ThenBy(o => o.ClassName))
            {
                Log.DebugFormat("Objectclass: {0}.{1}", objClass.Module.Namespace, objClass.ClassName);
                if (Case.IsNewObjectClassInheritance(objClass))
                {
                    Case.DoNewObjectClassInheritance(objClass);
                }
                if (Case.IsChangeObjectClassInheritance(objClass))
                {
                    Case.DoChangeObjectClassInheritance(objClass);
                }
                if (Case.IsRemoveObjectClassInheritance(objClass))
                {
                    Case.DoRemoveObjectClassInheritance(objClass);
                }
            }
            Log.Debug(String.Empty);
        }
    }
}
