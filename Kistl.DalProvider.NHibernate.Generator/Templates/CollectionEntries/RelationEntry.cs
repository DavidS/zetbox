
namespace Kistl.DalProvider.NHibernate.Generator.Templates.CollectionEntries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator.Extensions;
    using Templates = Kistl.Generator.Templates;

    public class RelationEntry
        : Templates.CollectionEntries.RelationEntry
    {
        public RelationEntry(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Relation rel)
            : base(_host, ctx, rel)
        {
        }

        protected override void ApplyConstructorTemplate()
        {
            // replace base constructors
            //base.ApplyConstructorTemplate();
            ObjectClasses.Constructors.Call(Host, ctx,
                new CompoundObjectProperty[0],
                GetCeInterface(),
                GetCeClassName(),
                null);
        }

        // test copy of base.ApplyObjectReferenceProperty() setting inverseNavigatorIsList = true and the proper ownInterface name
        // this can be folded into base when all N:M relations use OneNRelationLists
        protected override void ApplyObjectReferenceProperty(Relation rel, RelationEndRole endRole, string propertyName)
        {
            RelationEnd relEnd = rel.GetEndFromRole(endRole);
            RelationEnd otherEnd = rel.GetOtherEnd(relEnd);

            // TODO: create/use ObjectReference*IMPLEMENTATION* instead (_fk* can already be made available)
            string moduleNamespace = rel.Module.Namespace;
            string ownInterface = moduleNamespace + "." + rel.GetRelationClassName() + ImplementationSuffix;
            string name = propertyName;
            string implName = propertyName + ImplementationPropertySuffix;
            string eventName = "On" + name;
            string fkBackingName = "_fk_" + name;
            string fkGuidBackingName = "_fk_guid_" + name;
            string referencedInterface = relEnd.Type.GetDataTypeString();
            string referencedImplementation = referencedInterface + ImplementationSuffix;
            string associationName = rel.GetAssociationName();
            string targetRoleName = otherEnd.RoleName;
            string positionPropertyName = rel.NeedsPositionStorage(endRole)
                ? name + Kistl.API.Helper.PositionSuffix
                : null;
            string inverseNavigatorName = null; // do not care about inverse navigator
            bool inverseNavigatorIsList = false;
            bool eagerLoading = relEnd.Navigator != null && relEnd.Navigator.EagerLoading;
            bool relDataTypeExportable = rel.A.Type.ImplementsIExportable() && rel.B.Type.ImplementsIExportable();
            bool callGetterSetterEvents = false;

            Properties.ObjectReferencePropertyTemplate.Call(Host,
                ctx,
                MembersToSerialize,
                moduleNamespace,
                ownInterface,
                name,
                implName,
                eventName,
                fkBackingName,
                fkGuidBackingName,
                referencedInterface,
                referencedImplementation,
                associationName,
                targetRoleName,
                positionPropertyName,
                inverseNavigatorName,
                inverseNavigatorIsList,
                eagerLoading,
                relDataTypeExportable,
                callGetterSetterEvents);
        }

        protected override void ApplyAIndexPropertyTemplate()
        {
            // delegate interface to actual implementation
            Templates.Properties.DelegatingProperty.Call(Host, ctx, "AIndex", "int?", "this.A" + Kistl.API.Helper.PositionSuffix, "int?");
        }

        protected override void ApplyBIndexPropertyTemplate()
        {
            // delegate interface to actual implementation
            Templates.Properties.DelegatingProperty.Call(Host, ctx, "BIndex", "int?", "this.B" + Kistl.API.Helper.PositionSuffix, "int?");
        }

        protected override void ApplyClassTailTemplate()
        {
            base.ApplyClassTailTemplate();

            string interfaceName = GetCeInterface();

            List<KeyValuePair<string, string>> typeAndNameList = new List<KeyValuePair<string, string>>(){
                new KeyValuePair<string, string>(Mappings.ObjectClassHbm.GetProxyTypeReference(rel.A.Type, this.Settings), "A"),
                new KeyValuePair<string, string>(Mappings.ObjectClassHbm.GetProxyTypeReference(rel.B.Type, this.Settings), "B"),
            };

            if (IsOrdered())
            {
                typeAndNameList.Add(new KeyValuePair<string, string>("int?", "A" + Kistl.API.Helper.PositionSuffix));
                typeAndNameList.Add(new KeyValuePair<string, string>("int?", "B" + Kistl.API.Helper.PositionSuffix));
            }

            if (IsExportable())
            {
                typeAndNameList.Add(new KeyValuePair<string, string>("Guid", "ExportGuid"));
            }

            ObjectClasses.ProxyClass.Call(Host, ctx, interfaceName, new KeyValuePair<string, string>[0], typeAndNameList);
        }

        protected override string GetExportGuidBackingStoreReference()
        {
            return "this.Proxy.ExportGuid";
        }

        protected override void ApplyReloadReferenceBody()
        {
            {
                string referencedImplementation = Mappings.ObjectClassHbm.GetProxyTypeReference(rel.A.Type, Host.Settings);
                ObjectClasses.ReloadOneReference.Call(Host, ctx, null, referencedImplementation, "A", null, "_fk_A", "_fk_guid_A", IsExportable());
            }
            {
                string referencedImplementation = Mappings.ObjectClassHbm.GetProxyTypeReference(rel.B.Type, Host.Settings);
                ObjectClasses.ReloadOneReference.Call(Host, ctx, null, referencedImplementation, "B", null, "_fk_B", "_fk_guid_B", IsExportable());
            }
        }
    }
}
