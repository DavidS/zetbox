// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Metadefinition Object for Double Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DoubleParameter")]
    public class DoubleParameterMemoryImpl : Kistl.App.Base.BaseParameterMemoryImpl, DoubleParameter
    {
        [Obsolete]
        public DoubleParameterMemoryImpl()
            : base(null)
        {
        }

        public DoubleParameterMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DoubleParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DoubleParameter != null)
            {
                OnGetLabel_DoubleParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DoubleParameter> OnGetLabel_DoubleParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_DoubleParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_DoubleParameter != null)
            {
                OnGetParameterType_DoubleParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<DoubleParameter> OnGetParameterType_DoubleParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_DoubleParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_DoubleParameter != null)
            {
                OnGetParameterTypeString_DoubleParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<DoubleParameter> OnGetParameterTypeString_DoubleParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DoubleParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DoubleParameter)obj;
            var otherImpl = (DoubleParameterMemoryImpl)obj;
            var me = (DoubleParameter)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }


        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DoubleParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleParameter != null)
            {
                OnToString_DoubleParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DoubleParameter> OnToString_DoubleParameter;

        [EventBasedMethod("OnPreSave_DoubleParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DoubleParameter != null) OnPreSave_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnPreSave_DoubleParameter;

        [EventBasedMethod("OnPostSave_DoubleParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DoubleParameter != null) OnPostSave_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnPostSave_DoubleParameter;

        [EventBasedMethod("OnCreated_DoubleParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DoubleParameter != null) OnCreated_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnCreated_DoubleParameter;

        [EventBasedMethod("OnDeleting_DoubleParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DoubleParameter != null) OnDeleting_DoubleParameter(this);
        }
        public static event ObjectEventHandler<DoubleParameter> OnDeleting_DoubleParameter;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        #endregion

    }
}