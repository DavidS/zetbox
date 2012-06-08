namespace Zetbox.Client.Presentables.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.App.Calendar;
    using Zetbox.App.GUI;
    using Zetbox.Client.Presentables;

    [ViewModelDescriptor]
    public class CalendarRuleInstanceViewModel : ViewModel, IAppointmentViewModel
    {
        public new delegate CalendarRuleInstanceViewModel Factory(IZetboxContext dataCtx, ViewModel parent, CalendarRule rule, DateTime dt);

        public CalendarRuleInstanceViewModel(IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent, CalendarRule rule, DateTime dt)
            : base(appCtx, dataCtx, parent)
        {
            this.Rule = rule;
            this.Date = dt.Date;
        }

        public CalendarRule Rule { get; private set; }
        public DateTime Date { get; private set; }

        public override string Name
        {
            get { return Rule.Name; }
        }

        string IAppointmentViewModel.Subject
        {
            get { return Rule.Name; }
        }

        DateTime IAppointmentViewModel.From
        {
            get { return Date; }
        }

        DateTime IAppointmentViewModel.Until
        {
            get { return Date.AddDays(1); }
        }

        string IAppointmentViewModel.Location
        {
            get { return string.Empty; }
        }

        string IAppointmentViewModel.Body
        {
            get { return string.Empty; }
        }

        private string _color;
        string IAppointmentViewModel.Color
        {
            get { return !string.IsNullOrEmpty(_color) ? _color : "#00FF00"; }
            set { _color = value; OnPropertyChanged("Color"); }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { } // does not change
            remove { } // does not change
        }

        public ControlKind RequestedCalendarKind
        {
            get { return null; } // default
        }
    }
}
