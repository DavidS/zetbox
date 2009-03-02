
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
    /// Metadefinition Object for Enumeration Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="EnumerationProperty")]
    [System.Diagnostics.DebuggerDisplay("EnumerationProperty")]
    public class EnumerationProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, EnumerationProperty
    {


        /// <summary>
        /// Enumeration der Eigenschaft
        /// </summary>
    /*
    Relation: FK_EnumerationProperty_Enumeration_EnumerationProperty_48
    A: ZeroOrMore EnumerationProperty as EnumerationProperty
    B: ZeroOrOne Enumeration as Enumeration
    Preferred Storage: Left
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                return Enumeration__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                Enumeration__Implementation__ = (Kistl.App.Base.Enumeration__Implementation__)value;
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Enumeration
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) 
                    && Enumeration != null)
                {
                    _fk_Enumeration = Enumeration.ID;
                }
                return _fk_Enumeration;
            }
            set
            {
                _fk_Enumeration = value;
            }
        }
        private int? _fk_Enumeration;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_EnumerationProperty_Enumeration_EnumerationProperty_48", "Enumeration")]
        public Kistl.App.Base.Enumeration__Implementation__ Enumeration__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Enumeration__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Enumeration__Implementation__>(
                        "Model.FK_EnumerationProperty_Enumeration_EnumerationProperty_48",
                        "Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Enumeration__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Enumeration__Implementation__>(
                        "Model.FK_EnumerationProperty_Enumeration_EnumerationProperty_48",
                        "Enumeration");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Enumeration__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual int? Enumeration_pos
        {
            get
            {
                return _Enumeration_pos;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Enumeration_pos != value)
                {
                    NotifyPropertyChanging("Enumeration_pos");
                    _Enumeration_pos = value;
                    NotifyPropertyChanged("Enumeration_pos");
                }
            }
        }
        private int? _Enumeration_pos;
        

        /// <summary>
        /// 
        /// </summary>

		public override string GetGUIRepresentation() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetGUIRepresentation_EnumerationProperty != null)
            {
                OnGetGUIRepresentation_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetGUIRepresentation();
            }
            return e.Result;
        }
		public event GetGUIRepresentation_Handler<EnumerationProperty> OnGetGUIRepresentation_EnumerationProperty;



        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_EnumerationProperty != null)
            {
                OnGetPropertyType_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<EnumerationProperty> OnGetPropertyType_EnumerationProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_EnumerationProperty != null)
            {
                OnGetPropertyTypeString_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<EnumerationProperty> OnGetPropertyTypeString_EnumerationProperty;



		public override Type GetInterfaceType()
		{
			return typeof(EnumerationProperty);
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationProperty != null)
            {
                OnToString_EnumerationProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<EnumerationProperty> OnToString_EnumerationProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumerationProperty != null) OnPreSave_EnumerationProperty(this);
        }
        public event ObjectEventHandler<EnumerationProperty> OnPreSave_EnumerationProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumerationProperty != null) OnPostSave_EnumerationProperty(this);
        }
        public event ObjectEventHandler<EnumerationProperty> OnPostSave_EnumerationProperty;




#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            base.ToStream(binStream);
            BinarySerializer.ToStream(this.fk_Enumeration, binStream);
            BinarySerializer.ToStream(this._Enumeration_pos, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
            {
                var tmp = this.fk_Enumeration;
                BinarySerializer.FromStream(out tmp, binStream);
                this.fk_Enumeration = tmp;
            }
            BinarySerializer.FromStream(out this._Enumeration_pos, binStream);
        }

#endregion

    }


}