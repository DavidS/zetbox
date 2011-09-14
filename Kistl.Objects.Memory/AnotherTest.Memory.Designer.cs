// <autogenerated/>

namespace Kistl.App.Test
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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("AnotherTest")]
    public class AnotherTestMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, AnotherTest
    {
        [Obsolete]
        public AnotherTestMemoryImpl()
            : base(null)
        {
        }

        public AnotherTestMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        public override Type GetImplementedInterface()
        {
            return typeof(AnotherTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (AnotherTest)obj;
            var otherImpl = (AnotherTestMemoryImpl)obj;
            var me = (AnotherTest)this;

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
        [EventBasedMethod("OnToString_AnotherTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AnotherTest != null)
            {
                OnToString_AnotherTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<AnotherTest> OnToString_AnotherTest;

        [EventBasedMethod("OnPreSave_AnotherTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_AnotherTest != null) OnPreSave_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnPreSave_AnotherTest;

        [EventBasedMethod("OnPostSave_AnotherTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_AnotherTest != null) OnPostSave_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnPostSave_AnotherTest;

        [EventBasedMethod("OnCreated_AnotherTest")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_AnotherTest != null) OnCreated_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnCreated_AnotherTest;

        [EventBasedMethod("OnDeleting_AnotherTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_AnotherTest != null) OnDeleting_AnotherTest(this);
        }
        public static event ObjectEventHandler<AnotherTest> OnDeleting_AnotherTest;

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

        #endregion

    }
}