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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Describes the currently loaded physical database schema
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="CurrentSchema")]
    [System.Diagnostics.DebuggerDisplay("CurrentSchema")]
    public class CurrentSchema__Implementation__ : BaseServerDataObject_EntityFramework, CurrentSchema
    {
    
		public CurrentSchema__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// XML descriptor of the current schema
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Schema
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Schema;
                if (OnSchema_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnSchema_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Schema != value)
                {
                    var __oldValue = _Schema;
                    var __newValue = value;
                    if(OnSchema_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnSchema_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Schema", __oldValue, __newValue);
                    _Schema = __newValue;
                    NotifyPropertyChanged("Schema", __oldValue, __newValue);
                    if(OnSchema_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnSchema_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Schema;
		public event PropertyGetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_PostSetter;
        /// <summary>
        /// Version number of this schema
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int Version
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Version;
                if (OnVersion_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnVersion_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Version != value)
                {
                    var __oldValue = _Version;
                    var __newValue = value;
                    if(OnVersion_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnVersion_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Version", __oldValue, __newValue);
                    _Version = __newValue;
                    NotifyPropertyChanged("Version", __oldValue, __newValue);
                    if(OnVersion_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnVersion_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _Version;
		public event PropertyGetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(CurrentSchema));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (CurrentSchema)obj;
			var otherImpl = (CurrentSchema__Implementation__)obj;
			var me = (CurrentSchema)this;

			me.Schema = other.Schema;
			me.Version = other.Version;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CurrentSchema")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CurrentSchema != null)
            {
                OnToString_CurrentSchema(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<CurrentSchema> OnToString_CurrentSchema;

        [EventBasedMethod("OnPreSave_CurrentSchema")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CurrentSchema != null) OnPreSave_CurrentSchema(this);
        }
        public event ObjectEventHandler<CurrentSchema> OnPreSave_CurrentSchema;

        [EventBasedMethod("OnPostSave_CurrentSchema")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CurrentSchema != null) OnPostSave_CurrentSchema(this);
        }
        public event ObjectEventHandler<CurrentSchema> OnPostSave_CurrentSchema;

        [EventBasedMethod("OnCreated_CurrentSchema")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CurrentSchema != null) OnCreated_CurrentSchema(this);
        }
        public event ObjectEventHandler<CurrentSchema> OnCreated_CurrentSchema;

        [EventBasedMethod("OnDeleting_CurrentSchema")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CurrentSchema != null) OnDeleting_CurrentSchema(this);
        }
        public event ObjectEventHandler<CurrentSchema> OnDeleting_CurrentSchema;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Schema":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("175143b9-dd09-4b49-a633-e9cdb508c4c5")).Constraints
						.Where(c => !c.IsValid(this, this.Schema))
						.Select(c => c.GetErrorText(this, this.Schema))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Version":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("193c24c4-5a42-418e-8ed8-6e1689beca50")).Constraints
						.Where(c => !c.IsValid(this, this.Version))
						.Select(c => c.GetErrorText(this, this.Version))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Schema, binStream);
            BinarySerializer.ToStream(this._Version, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Schema, binStream);
            BinarySerializer.FromStream(out this._Version, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Schema, xml, "Schema", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Version, xml, "Version", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Schema, xml, "Schema", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Version, xml, "Version", "Kistl.App.Base");
        }

#endregion

    }


}