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

namespace Zetbox.App.Packaging
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Utils;
    using Zetbox.App.Base;
    using Zetbox.App.GUI;

    //
    //
    //
    // THIS FILE CONTAINS WORKAROUNDS. See Case 5232 for details.
    //
    //
    //

    internal static class PackagingHelper
    {
        private readonly static log4net.ILog Log = Logging.Exporter;

        public static List<IPersistenceObject> GetSchemaObjects(IZetboxContext ctx, Module module)
        {
            var result = new List<IPersistenceObject>();

            // break reference for linq
            int moduleID = module.ID;

            AddMetaObjects(result, () => ctx.GetQuery<Module>().Where(i => i.ID == moduleID).ToList().OrderBy(m => m.Name).ThenBy(i => i.ExportGuid));

            AddMetaObjects(result, () => ctx.GetQuery<DataType>().Where(i => i.Module.ID == moduleID)
                .ToList().OrderBy(i => i.Name).ThenBy(i => i.ExportGuid));

            AddMetaObjects(result, () => ctx.GetQuery<EnumerationEntry>().Where(i => i.Enumeration.Module.ID == moduleID)
                .ToList().OrderBy(i => i.Enumeration.Name).ThenBy(i => i.Name).ThenBy(i => i.ExportGuid));

            // export only relation entry ending on a "local" class. Since we do not have proper inter-module dependencies in place, we cannot support pushing interface implementations across modules.
            AddMetaObjects(result, () => ctx.Internals().GetPersistenceObjectQuery<DataType_implements_ImplementedInterfaces_RelationEntry>()
                // Workaround for missing Module relation on DataType_implements_Interface_RelationEntry when creating ZetboxBase.xml
                .Where(i => i.A != null && i.A.Module != null && i.B != null)
                .Where(i => i.A.Module == module)
                .ToList().OrderBy(i => i.A.Name).ThenBy(i => i.B.Name).ThenBy(i => i.A.ExportGuid).ThenBy(i => i.B.ExportGuid));
            AddMetaObjects(result, () => ctx.GetQuery<Property>().Where(i => i.Module.ID == moduleID)
                .ToList().OrderBy(i => i.ObjectClass.Name).ThenBy(i => i.Name).ThenBy(i => i.ExportGuid));

            AddMetaObjects(result, () => ctx.GetQuery<Relation>().Where(i => i.Module.ID == moduleID)
                .ToList().OrderBy(i => i.A.Type.Name).ThenBy(i => i.Verb).ThenBy(i => i.B.Type.Name).ThenBy(i => i.ExportGuid));
            // workaround a limitation / mapping error in NHibernate:
            AddMetaObjects(result, () => ctx.GetQuery<Relation>().Where(i => i.Module.ID == moduleID)
                .ToList()
                .SelectMany(rel => new RelationEnd[] { rel.A, rel.B })
                .AsQueryable()
                //AddMetaObjects(result, ctx.GetQuery<RelationEnd>().Where(i => (i.AParent != null && i.AParent.Module.ID == moduleID) || (i.BParent != null && i.BParent.Module.ID == moduleID))
                .ToList().OrderBy(i => i.Type.Name).ThenBy(i => i.RoleName).ThenBy(i => i.ExportGuid));

            // TODO: Add Module to Constraint - or should that not be changable by other modules?
            // All Property Contstraints
            AddMetaObjects(result, () => ctx.GetQuery<Zetbox.App.Base.Constraint>().Where(i => i.ConstrainedProperty.Module.ID == moduleID).ToList().AsQueryable() // local sorting because of GetInterfaceType
                .ToList().OrderBy(i => i.ConstrainedProperty.ObjectClass.Name).ThenBy(i => i.ConstrainedProperty.Name).ThenBy(i => ctx.GetInterfaceType(i).Type.Name).ThenBy(i => i.ExportGuid));

            // InstanceContstraints and Property Relation entries of UniqueConstraints
            AddMetaObjects(result, () => ctx.GetQuery<InstanceConstraint>().Where(i => i.Constrained.Module.ID == moduleID).ToList().AsQueryable() // local sorting because of GetInterfaceType
                .ToList().OrderBy(i => i.Constrained.Name).ThenBy(i => ctx.GetInterfaceType(i).Type.Name).ThenBy(i => i.ExportGuid));
            AddMetaObjects(result, () => ctx.Internals().GetPersistenceObjectQuery<UniqueContraints_ensures_unique_on_Properties_RelationEntry>().Where(i => i.A.Constrained.Module.ID == moduleID || i.B.Module.ID == moduleID).ToList().AsQueryable()
                .ToList().OrderBy(i => i.A.ExportGuid).ThenBy(i => i.B.ExportGuid));

            // TODO: Add Module to DefaultPropertyValue - or should that not be changable by other modules?
            AddMetaObjects(result, () => ctx.GetQuery<DefaultPropertyValue>().Where(i => i.Property.Module.ID == moduleID)
                .ToList().OrderBy(i => i.Property.ObjectClass.Name).ThenBy(i => i.Property.Name).ThenBy(i => i.ExportGuid));

            // Security
            AddMetaObjects(result, () => ctx.GetQuery<RoleMembership>().Where(i => i.Module.ID == moduleID)
                .ToList().OrderBy(i => i.ExportGuid));
            AddMetaObjects(result, () => ctx.Internals().GetPersistenceObjectQuery<RoleMembership_resolves_Relations_RelationEntry>().Where(i => i.A.Module.ID == moduleID)
                .ToList().AsQueryable().ToList().OrderBy(i => i.A.ExportGuid).ThenBy(i => i.B.ExportGuid));

            // Sequences
            AddMetaObjects(result, () => ctx.GetQuery<Sequence>().Where(i => i.Module != null && i.Module.ID == moduleID)
                .ToList().OrderBy(i => i.Description).ThenBy(i => i.ExportGuid));

            return result;
        }

        public static List<IPersistenceObject> GetMetaObjects(IZetboxContext ctx, Module module)
        {
            if (ctx == null) throw new ArgumentNullException("ctx");
            if (module == null) throw new ArgumentNullException("module");
            using (Logging.Exporter.DebugTraceMethodCall("GetMetaObjects", "Module = " + module.Name))
            {
                var result = GetSchemaObjects(ctx, module);

                // break reference for linq
                int moduleID = module.ID;

                AddMetaObjects(result, () => ctx.GetQuery<Method>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.ObjectClass.Name).ThenBy(i => i.Name).ThenBy(i => i.ExportGuid));
                AddMetaObjects(result, () => ctx.GetQuery<BaseParameter>().Where(i => i.Method.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.Method.ObjectClass.Name).ThenBy(i => i.Method.Name).ThenBy(i => i.Name).ThenBy(i => i.ExportGuid));

                AddMetaObjects(result, () => ctx.GetQuery<Assembly>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.Name).ThenBy(i => i.ExportGuid));

                var icons = ctx.GetQuery<Icon>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.IconFile).ThenBy(i => i.ExportGuid).ToList();
                AddMetaObjects(result, () => icons.AsQueryable());
                AddMetaObjects(result, () => icons.Select(i => i.Blob).AsQueryable());

                AddMetaObjects(result, () => ctx.GetQuery<ViewModelDescriptor>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.ViewModelTypeRef).ThenBy(i => i.ExportGuid));
                AddMetaObjects(result, () => ctx.GetQuery<ViewDescriptor>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.ControlTypeRef).ThenBy(i => i.ExportGuid));

                AddMetaObjects(result, () => ctx.GetQuery<NavigationEntry>()
                    .Where(i => i.Module.ID == moduleID)
                    .ToList()
                    .AsQueryable()
                    .ToList().OrderBy(i => i.Title)
                    .ThenBy(i => i.Parent != null ? i.Parent.Title : String.Empty)
                    .ThenBy(i => i.ExportGuid));
                AddMetaObjects(result, () => ctx.Internals().GetPersistenceObjectQuery<NavigationScreen_accessed_by_Groups_RelationEntry>()
                    .Where(i => i.A.Module.ID == moduleID)
                    .ToList()
                    .AsQueryable()
                    .ToList().OrderBy(i => i.A.Title)
                    .ThenBy(i => i.A.Parent != null ? i.A.Parent.Title : String.Empty)
                    .ThenBy(i => i.B.Name)
                    .ThenBy(i => i.A.ExportGuid));

                // Security
                AddMetaObjects(result, () => ctx.GetQuery<Group>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.Name).ThenBy(i => i.ExportGuid));
                AddMetaObjects(result, () => ctx.GetQuery<GroupMembership>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.ExportGuid));

                AddMetaObjects(result, () => ctx.GetQuery<ControlKind>().Where(i => i.Module.ID == moduleID)
                    .ToList().AsQueryable() // TODO: remove this workaround for GetInterfaceType()
                    .ToList().OrderBy(i => ctx.GetInterfaceType(i).Type.FullName)
                    .ThenBy(i => i.ExportGuid));
                AddMetaObjects(result, () => ctx.Internals().GetPersistenceObjectQuery<Presentable_displayedBy_SecondaryControlKinds_RelationEntry>()
                    .Where(i => i.A.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.A.ViewModelTypeRef)
                    .ThenBy(i => i.A.ExportGuid)
                    .ThenBy(i => i.B.ExportGuid));
                AddMetaObjects(result, () => ctx.GetQuery<FilterConfiguration>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.ExportGuid));
                AddMetaObjects(result, () => ctx.GetQuery<Application>().Where(i => i.Module.ID == moduleID)
                    .ToList().OrderBy(i => i.Name)
                    .ThenBy(i => i.ExportGuid));

                // Properties <-> Methods
                AddMetaObjects(result, () => ctx.Internals().GetPersistenceObjectQuery<ObjRefProp_shows_Methods_RelationEntry>()
                    .Where(i => i.A.Module.ID == moduleID || i.B.Module.ID == moduleID)
                    .ToList()
                    .OrderBy(i => i.A.Name)
                    .ThenBy(i => i.A.ExportGuid)
                    .ThenBy(i => i.B.ExportGuid));

                return result;
            }
        }

        public static List<Zetbox.App.Base.Module> GetModules(IReadOnlyZetboxContext ctx, string[] moduleNames)
        {
            var moduleList = new List<Zetbox.App.Base.Module>();
            if (moduleNames.Contains("*"))
            {
                moduleList.AddRange(ctx.GetQuery<Zetbox.App.Base.Module>());
            }
            else
            {
                foreach (var name in moduleNames)
                {
                    var module = ctx.GetQuery<Zetbox.App.Base.Module>().Where(m => m.Name == name).FirstOrDefault();
                    if (module == null)
                    {
                        Log.WarnFormat("Module {0} not found, skipping entry", name);
                        continue;
                    }
                    moduleList.Add(module);
                }
            }
            return moduleList.OrderBy(m => m.Name).ToList();
        }


        private static void AddMetaObjects<T>(List<IPersistenceObject> result, Func<IEnumerable<T>> objects)
            where T : IPersistenceObject
        {
            IEnumerable qryResult;
            try
            {
                // catch a possible exception
                // during an upgrade it might be, that certian meta objects are not available yet
                qryResult = objects().ToList();
            }
            catch (Exception ex)
            {
                Logging.Log.WarnFormat("Warning: Unable to query {0}, but will continue loading MetaObjects: {1}", typeof(T).FullName, ex.GetInnerMessage());
                return;
            }

            // TODO: always do a final stabilisation sort by ExportGuid
            // currently doesn't work, since EF doesn't like the cast
            foreach (IPersistenceObject obj in qryResult) //.ThenBy(o => ((IExportable)o).ExportGuid))
            {
                if (((IExportable)obj).ExportGuid == Guid.Empty)
                {
                    throw new InvalidOperationException(string.Format("At least one object of type {0} has an empty ExportGuid", typeof(T).FullName));
                }
                result.Add(obj);
            }
        }
    }
}
