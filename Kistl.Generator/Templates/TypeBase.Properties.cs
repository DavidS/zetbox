
namespace Kistl.Generator.Templates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator.Extensions;

    public partial class TypeBase
    {
        /// <summary>
        /// The list of members to serialize
        /// </summary>
        protected Serialization.SerializationMembersList MembersToSerialize { get { return _MembersToSerialize; } }
        private Serialization.SerializationMembersList _MembersToSerialize = new Serialization.SerializationMembersList();

        protected virtual void ApplyPropertyTemplate(Property p)
        {
            if (p is EnumerationProperty)
            {
                if (((EnumerationProperty)p).IsList)
                {
                    ApplyEnumerationListTemplate((EnumerationProperty)p);
                }
                else
                {
                    ApplyEnumerationPropertyTemplate((EnumerationProperty)p);
                    ApplyPropertyEvents(p, false);
                }
            }
            else if (p is ObjectReferenceProperty)
            {
                if (((ObjectReferenceProperty)p).IsList())
                {
                    ApplyObjectReferenceListTemplate((ObjectReferenceProperty)p);
                }
                else
                {
                    ApplyObjectReferencePropertyTemplate((ObjectReferenceProperty)p);
                    ApplyPropertyEvents(p, false);
                }
            }
            else if (p is CalculatedObjectReferenceProperty)
            {
                ApplyCalculatedObjectReferencePropertyTemplate((CalculatedObjectReferenceProperty)p);
                ApplyPropertyEvents(p, true);
            }
            else if (p is CompoundObjectProperty)
            {
                if (((CompoundObjectProperty)p).IsList)
                {
                    ApplyCompoundObjectListTemplate((CompoundObjectProperty)p);
                }
                else
                {
                    ApplyCompoundObjectPropertyTemplate((CompoundObjectProperty)p);
                    // no PropertyInvocationsTemplate for CompoundObject
                }
            }
            else if (p is ValueTypeProperty)
            {
                if (((ValueTypeProperty)p).IsList)
                {
                    ApplyValueTypeListTemplate((ValueTypeProperty)p);
                }
                else
                {
                    ApplyValueTypePropertyTemplate((ValueTypeProperty)p);
                    ApplyPropertyEvents(p, false);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("p", String.Format("unknown property type '{0}'", p.GetType().ToString()));
            }
        }

        protected virtual void ApplyPropertyEvents(Property p, bool isReadOnly)
        {
            Properties.PropertyEvents.Call(Host, ctx, p, isReadOnly);
        }

        protected virtual void ApplyEnumerationListTemplate(EnumerationProperty prop)
        {
            this.WriteLine("        // enumeration list property");
            ApplyListProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyEnumerationPropertyTemplate(EnumerationProperty prop)
        {
            this.WriteLine("        // enumeration property");
            this.ApplyNotifyingValueProperty(prop, null);
            this.MembersToSerialize.Add("Serialization.EnumBinarySerialization", Serialization.SerializerType.All, prop.Module.Namespace, prop.Name, prop);
        }

        protected virtual void ApplyObjectReferenceListTemplate(ObjectReferenceProperty prop)
        {
            this.WriteLine("        // object reference list property");
            ApplyListProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyObjectReferencePropertyTemplate(ObjectReferenceProperty prop)
        {
            this.WriteLine("        // object reference property");
            ApplyNotifyingValueProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyCalculatedObjectReferencePropertyTemplate(CalculatedObjectReferenceProperty prop)
        {
            this.WriteLine("        // calculated object reference property");
            ApplyCalculatedProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyCompoundObjectListTemplate(CompoundObjectProperty prop)
        {
            this.WriteLine("        // CompoundObject list property");
            ApplyListProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyCompoundObjectPropertyTemplate(CompoundObjectProperty prop)
        {
            this.WriteLine("        // CompoundObject property");
            ApplyNotifyingValueProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyValueTypeListTemplate(ValueTypeProperty prop)
        {
            this.WriteLine("        // value list property");
            ApplyListProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyValueTypePropertyTemplate(ValueTypeProperty prop)
        {
            this.WriteLine("        // value type property");
            ApplyNotifyingValueProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyOtherListTemplate(Property prop)
        {
            this.WriteLine("        // other list property");
            ApplyListProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyOtherPropertyTemplate(Property prop)
        {
            this.WriteLine("        // other property");
            ApplyNotifyingValueProperty(prop, this.MembersToSerialize);
        }

        protected virtual void ApplyNotifyingValueProperty(Property prop, Serialization.SerializationMembersList serList)
        {
            Properties.NotifyingDataProperty.Call(Host, ctx,
                serList, prop);
        }

        protected virtual void ApplyListProperty(Property prop, Serialization.SerializationMembersList serList)
        {
            Properties.ListProperty.Call(Host, ctx,
                serList,
                this.DataType,
                prop.Name,
                prop);
        }

        protected virtual void ApplyCalculatedProperty(CalculatedObjectReferenceProperty prop, Serialization.SerializationMembersList serList)
        {
            Properties.CalculatedProperty.Call(Host, ctx,
                serList, prop);
        }
    }
}
