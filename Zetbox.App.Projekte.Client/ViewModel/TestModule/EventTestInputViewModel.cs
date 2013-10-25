namespace Zetbox.App.Projekte.Client.ViewModel.TestModule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.Client.Presentables;
    using Zetbox.API;
    using Zetbox.Client.Presentables.Calendar;
    using System.ComponentModel;
    using cal = Zetbox.App.Calendar;

    [ViewModelDescriptor]
    public class EventTestInputViewModel : EventInputViewModel, IEventInputViewModel
    {
        public new delegate EventTestInputViewModel Factory(IZetboxContext dataCtx, ViewModel parent, cal.CalendarBook targetCalendar, DateTime selectedStartDate, bool isAllDay);

        public EventTestInputViewModel(IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent, cal.CalendarBook targetCalendar, DateTime selectedStartDate, bool isAllDay)
            : base(appCtx, dataCtx, parent, targetCalendar, selectedStartDate, isAllDay)
        {
            // Zetbox.App.Test.EventTestObject
        }

        public override string Name
        {
            get { return "EventTestInputViewModel"; }
        }

        public override string Error
        {
            get
            {
                var sb = new StringBuilder();

                if (!string.IsNullOrEmpty(StartDate.Error)) sb.AppendLine(StartDate.Error);
                if (!string.IsNullOrEmpty(EndDate.Error)) sb.AppendLine(EndDate.Error);

                return sb.ToString();
            }
        }

        public override EventViewModel CreateNew()
        {
            var vmdl = base.CreateNew();
            if (vmdl == null) return null;

            var evt = vmdl.Event;
            var obj = DataContext.Create<Zetbox.App.Test.EventTestObject>();

            obj.Name = string.Format("Created on '{0}'", DateTime.Now);
            obj.Event = evt;

            evt.Summary = "A test event linking to " + obj.Name;

            DataContext.SubmitChanges(); // TODO: Workaround limitations of setting a any reference to a new object
            evt.Source.SetObject(obj);
            return vmdl;
        }
    }
}
