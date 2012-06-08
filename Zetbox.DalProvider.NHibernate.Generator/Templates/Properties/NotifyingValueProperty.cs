
namespace Zetbox.DalProvider.NHibernate.Generator.Templates.Properties
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.App.Base;
    using Templates = Zetbox.Generator.Templates;

    public class NotifyingValueProperty
        : Templates.Properties.NotifyingValueProperty
    {
        public NotifyingValueProperty(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Templates.Serialization.SerializationMembersList serializationList, string type, string name, string modulenamespace, string backingName, bool isCalculated)
            : base(_host, ctx, serializationList, type, name, modulenamespace, "Proxy." + name, isCalculated)
        {
        }

        protected override MemberAttributes ModifyMemberAttributes(MemberAttributes memberAttributes)
        {
            return base.ModifyMemberAttributes(memberAttributes) & ~MemberAttributes.Final;
        }

        protected override void ApplyBackingStoreDefinition()
        {
            // the proxy store the value, so we don't need a local backing store
            // base.ApplyBackingStoreDefinition();
        }

        protected override void ApplyBackingStoreIsDirtyDefinition()
        {
            // the proxy store the value, so we don't need a local backing store
            // base.ApplyBackingStoreIsDirtyDefinition();
        }

        protected override void AddSerialization(Templates.Serialization.SerializationMembersList list, string name)
        {
            if (list != null)
            {
                Templates.Serialization.SimplePropertySerialization
                    .AddToSerializers(list, Templates.Serialization.SerializerType.All, modulenamespace, name, type, backingName);
            }
        }
    }
}
