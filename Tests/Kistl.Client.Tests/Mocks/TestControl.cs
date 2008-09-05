using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.GUI.DB;
using Kistl.GUI;
using Kistl.API;
using Kistl.GUI.Renderer;
using System.Collections.ObjectModel;
using Kistl.App.GUI;

namespace Kistl.Client.Mocks
{

    public class TestRenderer : BasicRenderer<object, object, object>
    {
        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.Renderer,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestRenderer"
            };

        public override Toolkit Platform { get { return Toolkit.TEST; } }

        public override void ShowMessage(string msg)
        {
            throw new NotImplementedException();
        }

        protected override void ShowObject(IDataObject obj, object ctrl)
        {
            throw new NotImplementedException();
        }

        protected override object Setup(object control)
        {
            return control;
        }

        protected override object Setup(object widget, IList<object> list)
        {
            return widget;
        }

        public override IDataObject ChooseObject(IKistlContext ctx, Type klass, string prompt)
        {
            throw new NotImplementedException();
        }
    }

    public class TestBasicControl : IBasicControl
    {
        #region IBasicControl Members

        public string Description { get; set; }
        public string ShortLabel { get; set; }
        public FieldSize Size { get; set; }
        public IKistlContext Context { get; set; }

        #endregion
    }

    public class TestObjectControl : TestBasicControl, IObjectControl
    {
        public readonly static ControlInfo Info
          = new ControlInfo()
          {
              Platform = Toolkit.TEST,
              ControlType = VisualType.Object,
              IsContainer = false,
              // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
              ClassName = "Kistl.Client.Mocks.TestObjectControl"
          };

        #region IObjectControl Members

        public IDataObject Value { get; set; }

        public event EventHandler UserInput;
        public event EventHandler UserSaveRequest;
        public event EventHandler UserDeleteRequest;

        #endregion
    }

    public class TestBoolControl : TestBasicControl, IValueControl<bool?>
    {
        public TestBoolControl()
        {
            Description = "TestBoolControl Description";
            ShortLabel = "TBC ShortLabel";
            Size = FieldSize.Full;
            IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.Boolean,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestBoolControl"
            };



        #region IBoolControl Members

        public event EventHandler UserInput;
        public bool? Value { get; set; }
        public bool IsValidValue { get; set; }

        #endregion

        internal void SimulateUserInput(bool? newBoolValue)
        {
            Value = newBoolValue;
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }
    }

    public class TestDateTimeControl : TestBasicControl, IValueControl<DateTime?>
    {
        public TestDateTimeControl()
        {
            Description = "TestDateTimeControl Description";
            ShortLabel = "TBC ShortLabel";
            Size = FieldSize.Full;
            IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.DateTime,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestDateTimeControl"
            };

        #region IDateTimeControl Members

        public event EventHandler UserInput;
        public DateTime? Value { get; set; }

        public bool IsValidValue { get; set; }

        #endregion

        internal void SimulateUserInput(DateTime? newDateTimeValue)
        {
            Value = newDateTimeValue;
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }
    }

    public class TestIntControl : TestBasicControl, IValueControl<int?>
    {
        public TestIntControl()
        {
            Description = "TestIntControl Description";
            ShortLabel = "TIC ShortLabel";
            Size = FieldSize.Full;
            IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.Integer,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestIntControl"
            };

        #region IIntControl Members

        public event EventHandler UserInput;
        public int? Value { get; set; }

        public bool IsValidValue { get; set; }
        #endregion

        internal void SimulateUserInput(int? newIntValue)
        {
            Value = newIntValue;
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }
    }

    public class TestDoubleControl : TestBasicControl, IValueControl<double?>
    {
        public TestDoubleControl()
        {
            Description = "TestDoubleControl Description";
            ShortLabel = "TDC ShortLabel";
            Size = FieldSize.Full;
            IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.Double,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestDoubleControl"
            };

        #region IDoubleControl Members

        public event EventHandler UserInput;
        public double? Value { get; set; }

        public bool IsValidValue { get; set; }
        #endregion

        internal void SimulateUserInput(double? newDoubleValue)
        {
            Value = newDoubleValue;
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }
    }

    public class TestStringControl : TestBasicControl, IValueControl<string>
    {
        public TestStringControl()
        {
            Description = "TestStringControl Description";
            ShortLabel = "TSC ShortLabel";
            Size = FieldSize.Full;
            IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.String,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestStringControl"
            };

        #region IStringControl Members

        public event EventHandler UserInput;
        public string Value { get; set; }
        public bool IsValidValue { get; set; }

        #endregion

        internal void SimulateUserInput(string newStringValue)
        {
            Value = newStringValue;
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }
    }

    public class TestObjectReferenceControl : TestBasicControl, IReferenceControl
    {
        public TestObjectReferenceControl()
        {
            Description = "TestObjectReferenceControl Description";
            ShortLabel = "TORC ShortLabel";
            Size = FieldSize.Full;
            IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.ObjectReference,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestObjectReferenceControl"
            };

        internal void SimulateUserInput(IDataObject newValue)
        {
            Value = newValue;
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }

        #region IValueControl Members

        public event EventHandler UserInput;
        public IDataObject Value { get; set; }
        public bool IsValidValue { get; set; }

        #endregion

        #region IReferenceControl<IDataObject> Member

        public Type ObjectType { get; set; }

        #endregion

        #region IObjectReferenceControl Members

        public IList<IDataObject> ItemsSource { get; set; }

        #endregion

    }

    public class TestObjectListControl
        : TestBasicControl, IReferenceListControl
    {
        public TestObjectListControl()
        {
            Description = "TestObjectListControl Description";
            ShortLabel = "TOLC ShortLabel";
            Size = FieldSize.Full;
            // IsValidValue = true;
        }

        public readonly static ControlInfo Info
            = new ControlInfo()
            {
                Platform = Toolkit.TEST,
                ControlType = VisualType.ObjectList,
                IsContainer = false,
                // AssemblyName = "Kistl.Client.Tests, Version=1.0.0.0",
                ClassName = "Kistl.Client.Mocks.TestObjectListControl"
            };

        internal void SimulateUserInput(ObservableCollection<IDataObject> newValue)
        {
            Value = newValue ?? new ObservableCollection<IDataObject>();
            if (UserInput != null)
                UserInput(this, new EventArgs());
        }

        #region IReferenceControl<ObservableCollection<IDataObject>> Members

        public IList<IDataObject> ItemsSource { get; set; }
        public Type ObjectType { get; set; }

        public event EventHandler UserAddRequest;
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler UserChangedListEvent;

        #endregion

        #region IValueControl<ObservableCollection<IDataObject>> Members

        public ObservableCollection<IDataObject> Value { get; set; }

        public bool IsValidValue { get; set; }

        public event EventHandler UserInput;

        #endregion

    }
}
