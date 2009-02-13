
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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IntegerRangeConstraint")]
    public class IntegerRangeConstraint__Implementation__ : Kistl.App.Base.Constraint__Implementation__, IntegerRangeConstraint
    {


        /// <summary>
        /// The biggest value accepted by this constraint
        /// </summary>
        // value type property
        public virtual int Max
        {
            get
            {
                return _Max;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Max != value)
                {
                    NotifyPropertyChanging("Max");
                    _Max = value;
                    NotifyPropertyChanged("Max");;
                }
            }
        }
        private int _Max;

        /// <summary>
        /// The smallest value accepted by this constraint
        /// </summary>
        // value type property
        public virtual int Min
        {
            get
            {
                return _Min;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Min != value)
                {
                    NotifyPropertyChanging("Min");
                    _Min = value;
                    NotifyPropertyChanged("Min");;
                }
            }
        }
        private int _Min;

        /// <summary>
        /// 
        /// </summary>

		public override bool IsValid(System.Object constrainedValue, System.Object constrainedObj) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IntegerRangeConstraint != null)
            {
                OnIsValid_IntegerRangeConstraint(this, e, constrainedValue, constrainedObj);
            };
            return e.Result;
        }
		public event IsValid_Handler<IntegerRangeConstraint> OnIsValid_IntegerRangeConstraint;



        /// <summary>
        /// 
        /// </summary>

		public override string GetErrorText(System.Object constrainedValue, System.Object constrainedObject) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IntegerRangeConstraint != null)
            {
                OnGetErrorText_IntegerRangeConstraint(this, e, constrainedValue, constrainedObject);
            };
            return e.Result;
        }
		public event GetErrorText_Handler<IntegerRangeConstraint> OnGetErrorText_IntegerRangeConstraint;



        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntegerRangeConstraint != null)
            {
                OnToString_IntegerRangeConstraint(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<IntegerRangeConstraint> OnToString_IntegerRangeConstraint;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IntegerRangeConstraint != null) OnPreSave_IntegerRangeConstraint(this);
        }
        public event ObjectEventHandler<IntegerRangeConstraint> OnPreSave_IntegerRangeConstraint;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IntegerRangeConstraint != null) OnPostSave_IntegerRangeConstraint(this);
        }
        public event ObjectEventHandler<IntegerRangeConstraint> OnPostSave_IntegerRangeConstraint;


        internal IntegerRangeConstraint__Implementation__(FrozenContext ctx, int id)
            : base(ctx, id)
        { }


#region Serializer

        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.IO.BinaryReader binStream)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}