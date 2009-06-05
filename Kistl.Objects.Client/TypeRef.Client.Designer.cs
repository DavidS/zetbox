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

    using Kistl.API.Client;
    using Kistl.DalProvider.ClientObjects;

    /// <summary>
    /// This class models a reference to a specific, concrete Type. Generic Types have all parameters filled.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TypeRef")]
    public class TypeRef__Implementation__ : BaseClientDataObject_ClientObjects, TypeRef, Kistl.API.IExportableInternal
    {
    
		public TypeRef__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// The assembly containing the referenced Type.
        /// </summary>
        // object reference property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                if (_fk_Assembly.HasValue)
                    return Context.Find<Kistl.App.Base.Assembly>(_fk_Assembly.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Assembly == null)
					return;
                else if (value != null && value.ID == _fk_Assembly)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Assembly;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Assembly", oldValue, value);
                
				// next, set the local reference
                _fk_Assembly = value == null ? (int?)null : value.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Assembly", oldValue, value);
            }
        }
        
        private int? _fk_Assembly;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Guid ExportGuid
        {
            get
            {
                return _ExportGuid;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
                    NotifyPropertyChanging("ExportGuid", __oldValue, value);
                    _ExportGuid = value;
                    NotifyPropertyChanged("ExportGuid", __oldValue, value);
                }
            }
        }
        private Guid _ExportGuid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_FullName != value)
                {
					var __oldValue = _FullName;
                    NotifyPropertyChanging("FullName", __oldValue, value);
                    _FullName = value;
                    NotifyPropertyChanged("FullName", __oldValue, value);
                }
            }
        }
        private string _FullName;

        /// <summary>
        /// list of type arguments
        /// </summary>
        // collection reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.CollectionEntryListProperty
		public IList<Kistl.App.Base.TypeRef> GenericArguments
		{
			get
			{
				if (_GenericArguments == null)
				{
					_GenericArguments 
						= new ClientRelationBSideListWrapper<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__>(
							this, 
							new RelationshipFilterASideCollection<TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__>(this.Context, this));
				}
				return _GenericArguments;
			}
		}

		private ClientRelationBSideListWrapper<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, TypeRef_hasGenericArguments_TypeRef_RelationEntry__Implementation__> _GenericArguments;

        /// <summary>
        /// The TypeRef of the BaseClass of the referenced Type
        /// </summary>
        // object reference property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Parent
        {
            get
            {
                if (_fk_Parent.HasValue)
                    return Context.Find<Kistl.App.Base.TypeRef>(_fk_Parent.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Parent == null)
					return;
                else if (value != null && value.ID == _fk_Parent)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Parent;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Parent", oldValue, value);
                
				// next, set the local reference
                _fk_Parent = value == null ? (int?)null : value.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Parent", oldValue, value);
            }
        }
        
        private int? _fk_Parent;

        /// <summary>
        /// get the referenced <see cref="System.Type"/>
        /// </summary>

		public virtual System.Type AsType(System.Boolean throwOnError) 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnAsType_TypeRef != null)
            {
                OnAsType_TypeRef(this, e, throwOnError);
            }
            else
            {
                throw new NotImplementedException("No handler registered on TypeRef.AsType");
            }
            return e.Result;
        }
		public delegate void AsType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret, System.Boolean throwOnError);
		public event AsType_Handler<TypeRef> OnAsType_TypeRef;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TypeRef));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (TypeRef)obj;
			var otherImpl = (TypeRef__Implementation__)obj;
			var me = (TypeRef)this;

			me.ExportGuid = other.ExportGuid;
			me.FullName = other.FullName;
			this._fk_Assembly = otherImpl._fk_Assembly;
			this._fk_Parent = otherImpl._fk_Parent;
		}

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TypeRef != null)
            {
                OnToString_TypeRef(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<TypeRef> OnToString_TypeRef;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TypeRef != null) OnPreSave_TypeRef(this);
        }
        public event ObjectEventHandler<TypeRef> OnPreSave_TypeRef;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TypeRef != null) OnPostSave_TypeRef(this);
        }
        public event ObjectEventHandler<TypeRef> OnPostSave_TypeRef;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Assembly":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(206).Constraints
						.Where(c => !c.IsValid(this, this.Assembly))
						.Select(c => c.GetErrorText(this, this.Assembly))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(263).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "FullName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(205).Constraints
						.Where(c => !c.IsValid(this, this.FullName))
						.Select(c => c.GetErrorText(this, this.FullName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "GenericArguments":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(207).Constraints
						.Where(c => !c.IsValid(this, this.GenericArguments))
						.Select(c => c.GetErrorText(this, this.GenericArguments))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Parent":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(235).Constraints
						.Where(c => !c.IsValid(this, this.Parent))
						.Select(c => c.GetErrorText(this, this.Parent))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
                case "Assembly":
                    _fk_Assembly = id;
                    break;
                case "Parent":
                    _fk_Parent = id;
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._fk_Assembly, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._FullName, binStream);
			{
				foreach(var obj in GenericArguments)
				{
					auxObjects.Add(obj);
				}
			}
            BinarySerializer.ToStream(this._fk_Parent, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Assembly, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._FullName, binStream);
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._fk_Assembly, xml, "Assembly", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(this._FullName, xml, "FullName", "Kistl.App.Base");
            XmlStreamer.ToStream(this._fk_Parent, xml, "Parent", "http://dasz.at/Kistl");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Assembly, xml, "Assembly", "http://dasz.at/Kistl");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._FullName, xml, "FullName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "http://dasz.at/Kistl");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._FullName, xml, "FullName", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._FullName, xml, "FullName", "Kistl.App.Base");
        }

#endregion

    }


}