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

    using Kistl.DalProvider.Frozen;

    /// <summary>
    /// Base Metadefinition Object for Objectclasses, Interfaces, Structs and Enumerations.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DataType")]
    public class DataType__Implementation__Frozen : BaseFrozenDataObject, DataType, Kistl.API.IExportableInternal
    {
    
		public DataType__Implementation__Frozen()
		{
        }


        /// <summary>
        /// Der Name der Objektklasse
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ClassName != value)
                {
					var __oldValue = _ClassName;
                    NotifyPropertyChanging("ClassName", __oldValue, value);
                    _ClassName = value;
                    NotifyPropertyChanged("ClassName", __oldValue, value);
                }
            }
        }
        private string _ClassName;

        /// <summary>
        /// Standard Icon wenn IIcon nicht implementiert ist
        /// </summary>
        // object reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Kistl.App.GUI.Icon DefaultIcon
        {
            get
            {
                return _DefaultIcon;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_DefaultIcon != value)
                {
					var __oldValue = _DefaultIcon;
                    NotifyPropertyChanging("DefaultIcon", __oldValue, value);
                    _DefaultIcon = value;
                    NotifyPropertyChanged("DefaultIcon", __oldValue, value);
                }
            }
        }
        private Kistl.App.GUI.Icon _DefaultIcon;

        /// <summary>
        /// Description of this DataType
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

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
        /// all implemented Methods in this DataType
        /// </summary>
        // object list property
   		// Kistl.Server.Generators.FrozenObjects.Implementation.ObjectClasses.ListProperty
        public virtual ICollection<Kistl.App.Base.MethodInvocation> MethodInvocations
        {
            get
            {
                if (_MethodInvocations == null)
                    _MethodInvocations = new ReadOnlyCollection<Kistl.App.Base.MethodInvocation>(new List<Kistl.App.Base.MethodInvocation>(0));
                return _MethodInvocations;
            }
            internal set
            {
                if (((IPersistenceObject)this).IsReadonly)
                {
                    throw new ReadOnlyObjectException();
                }
                _MethodInvocations = (ReadOnlyCollection<Kistl.App.Base.MethodInvocation>)value;
            }
        }
        private ReadOnlyCollection<Kistl.App.Base.MethodInvocation> _MethodInvocations;

        /// <summary>
        /// Liste aller Methoden der Objektklasse.
        /// </summary>
        // object list property
   		// Kistl.Server.Generators.FrozenObjects.Implementation.ObjectClasses.ListProperty
        public virtual ICollection<Kistl.App.Base.Method> Methods
        {
            get
            {
                if (_Methods == null)
                    _Methods = new ReadOnlyCollection<Kistl.App.Base.Method>(new List<Kistl.App.Base.Method>(0));
                return _Methods;
            }
            internal set
            {
                if (((IPersistenceObject)this).IsReadonly)
                {
                    throw new ReadOnlyObjectException();
                }
                _Methods = (ReadOnlyCollection<Kistl.App.Base.Method>)value;
            }
        }
        private ReadOnlyCollection<Kistl.App.Base.Method> _Methods;

        /// <summary>
        /// Modul der Objektklasse
        /// </summary>
        // object reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual Kistl.App.Base.Module Module
        {
            get
            {
                return _Module;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Module != value)
                {
					var __oldValue = _Module;
                    NotifyPropertyChanging("Module", __oldValue, value);
                    _Module = value;
                    NotifyPropertyChanged("Module", __oldValue, value);
                }
            }
        }
        private Kistl.App.Base.Module _Module;

        /// <summary>
        /// Eigenschaften der Objektklasse
        /// </summary>
        // object list property
   		// Kistl.Server.Generators.FrozenObjects.Implementation.ObjectClasses.ListProperty
        public virtual ICollection<Kistl.App.Base.Property> Properties
        {
            get
            {
                if (_Properties == null)
                    _Properties = new ReadOnlyCollection<Kistl.App.Base.Property>(new List<Kistl.App.Base.Property>(0));
                return _Properties;
            }
            internal set
            {
                if (((IPersistenceObject)this).IsReadonly)
                {
                    throw new ReadOnlyObjectException();
                }
                _Properties = (ReadOnlyCollection<Kistl.App.Base.Property>)value;
            }
        }
        private ReadOnlyCollection<Kistl.App.Base.Property> _Properties;

        /// <summary>
        /// 
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool ShowIconInLists
        {
            get
            {
                return _ShowIconInLists;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowIconInLists != value)
                {
					var __oldValue = _ShowIconInLists;
                    NotifyPropertyChanging("ShowIconInLists", __oldValue, value);
                    _ShowIconInLists = value;
                    NotifyPropertyChanged("ShowIconInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowIconInLists;

        /// <summary>
        /// 
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool ShowIdInLists
        {
            get
            {
                return _ShowIdInLists;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowIdInLists != value)
                {
					var __oldValue = _ShowIdInLists;
                    NotifyPropertyChanging("ShowIdInLists", __oldValue, value);
                    _ShowIdInLists = value;
                    NotifyPropertyChanged("ShowIdInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowIdInLists;

        /// <summary>
        /// 
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool ShowNameInLists
        {
            get
            {
                return _ShowNameInLists;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowNameInLists != value)
                {
					var __oldValue = _ShowNameInLists;
                    NotifyPropertyChanging("ShowNameInLists", __oldValue, value);
                    _ShowNameInLists = value;
                    NotifyPropertyChanged("ShowNameInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowNameInLists;

        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>

		public virtual System.Type GetDataType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_DataType != null)
            {
                OnGetDataType_DataType(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on DataType.GetDataType");
            }
            return e.Result;
        }
		public delegate void GetDataType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret);
		public event GetDataType_Handler<DataType> OnGetDataType_DataType;



        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>

		public virtual string GetDataTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_DataType != null)
            {
                OnGetDataTypeString_DataType(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on DataType.GetDataTypeString");
            }
            return e.Result;
        }
		public delegate void GetDataTypeString_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public event GetDataTypeString_Handler<DataType> OnGetDataTypeString_DataType;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DataType));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DataType != null)
            {
                OnToString_DataType(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<DataType> OnToString_DataType;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DataType != null) OnPreSave_DataType(this);
        }
        public event ObjectEventHandler<DataType> OnPreSave_DataType;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DataType != null) OnPostSave_DataType(this);
        }
        public event ObjectEventHandler<DataType> OnPostSave_DataType;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "ClassName":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(1).Constraints
						.Where(c => !c.IsValid(this, this.ClassName))
						.Select(c => c.GetErrorText(this, this.ClassName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "DefaultIcon":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(69).Constraints
						.Where(c => !c.IsValid(this, this.DefaultIcon))
						.Select(c => c.GetErrorText(this, this.DefaultIcon))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(175).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(252).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MethodInvocations":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(80).Constraints
						.Where(c => !c.IsValid(this, this.MethodInvocations))
						.Select(c => c.GetErrorText(this, this.MethodInvocations))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Methods":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(31).Constraints
						.Where(c => !c.IsValid(this, this.Methods))
						.Select(c => c.GetErrorText(this, this.Methods))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(45).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Properties":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(7).Constraints
						.Where(c => !c.IsValid(this, this.Properties))
						.Select(c => c.GetErrorText(this, this.Properties))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowIconInLists":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(265).Constraints
						.Where(c => !c.IsValid(this, this.ShowIconInLists))
						.Select(c => c.GetErrorText(this, this.ShowIconInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowIdInLists":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(266).Constraints
						.Where(c => !c.IsValid(this, this.ShowIdInLists))
						.Select(c => c.GetErrorText(this, this.ShowIdInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowNameInLists":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(264).Constraints
						.Where(c => !c.IsValid(this, this.ShowNameInLists))
						.Select(c => c.GetErrorText(this, this.ShowNameInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}
        internal DataType__Implementation__Frozen(int id)
            : base(id)
        { }


		internal static Dictionary<int, DataType__Implementation__Frozen> DataStore = new Dictionary<int, DataType__Implementation__Frozen>(0);
		internal static void CreateInstances()
		{
		}

		internal static void FillDataStore() {
	
		}
#region Serializer

        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.IO.BinaryReader binStream)
        {
            throw new NotImplementedException();
        }
        public override void ToStream(System.Xml.XmlWriter xml)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }
        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}