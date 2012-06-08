
namespace Zetbox.Generator.Templates.Properties
{
    using System;
    using System.CodeDom;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.Generator.Extensions;

    public partial class NotifyingValueProperty
    {
        public static void Call(Arebis.CodeGeneration.IGenerationHost host,
            IZetboxContext ctx, Serialization.SerializationMembersList serializationList,
            string type, string name, string modulenamespace, bool isCalculated)
        {
            if (host == null) { throw new ArgumentNullException("host"); }

            string backingName = "_" + name;

            Call(host, ctx, serializationList, type, name, modulenamespace, backingName, isCalculated);
        }

        protected virtual void ApplySecurityCheckTemplate()
        {
            this.WriteLine("                if (!CurrentAccessRights.HasReadRights()) return default({0});", type);
        }

        /// <summary>
        /// Is called to insert requisites into the containing class, like wrappers or similar.
        /// </summary>
        protected virtual void ApplyRequisitesTemplate() { }

        /// <summary>
        /// Is called to apply optional decoration in front of the property declaration, like Attributes.
        /// </summary>
        protected virtual void ApplyAttributesTemplate() { }

        protected virtual void ApplyTailTemplate() { }

        protected virtual void AddSerialization(Serialization.SerializationMembersList list, string name)
        {
            if (list != null)
                list.Add(Serialization.SerializerType.All, modulenamespace, name, type, backingName);
        }

        protected virtual void ApplyOnGetTemplate() { }
        protected virtual void ApplyOnAllSetTemplate() { }
        protected virtual void ApplyPreSetTemplate() { }
        protected virtual void ApplyPostSetTemplate() { }

        protected virtual void ApplyBackingStoreDefinition()
        {
            this.WriteLine("        private {0} {1};", type, backingName);
        }

        protected virtual void ApplyBackingStoreIsDirtyDefinition()
        {
            if (isCalculated)
                this.WriteLine("        private bool {0}_IsDirty = false;", backingName);
        }
    }
}
