// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// A recurrence rule
    /// </summary>
    [Zetbox.API.DefinitionGuid("3d4ec88b-fe8e-452e-a71d-03143a75aeb0")]
    public interface RecurrenceRule : ICompoundObject 
    {

        /// <summary>
        /// Specifies a comma separated list of days of the week. Also it may indicate the nth occurrence of the specific day within a month. (MO,TU,1SA,-2SU)
        /// </summary>
        [Zetbox.API.DefinitionGuid("c5f5b1dd-dc45-4502-a6ea-f81dd6ce2dc3")]
        string ByDay {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of hours. (0,1,22,23)
        /// </summary>
        [Zetbox.API.DefinitionGuid("074b76a7-0c27-467b-9720-2c954aa7c3d9")]
        string ByHour {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of minutes. (0,1,58,59)
        /// </summary>
        [Zetbox.API.DefinitionGuid("96521cbb-eb24-4a3e-a917-0976c3a11e6f")]
        string ByMinute {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of months of the year (1,2,3,4,11,12)
        /// </summary>
        [Zetbox.API.DefinitionGuid("b2c3e98f-030c-4b0a-8638-e5d2086e6f93")]
        string ByMonth {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of days of the month. (1,2,30,31,-1,-2,-31)
        /// </summary>
        [Zetbox.API.DefinitionGuid("660cf3f4-557a-4968-9f8a-71c5cfe34424")]
        string ByMonthDay {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of seconds. (0,1,58,59)
        /// </summary>
        [Zetbox.API.DefinitionGuid("5946adc5-ae48-4739-9dd0-89dc81c95544")]
        string BySecond {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of nth occurrences
        /// </summary>
        [Zetbox.API.DefinitionGuid("6ac6b5fa-70da-4175-bf68-125413281295")]
        string BySetPos {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of weeks of the year. Valid values are 1 to 53 or -53 to -1. (1,5,-2)
        /// </summary>
        [Zetbox.API.DefinitionGuid("60280e01-18f6-483a-91ae-d413ea10dc10")]
        string ByWeekNumber {
            get;
            set;
        }


        /// <summary>
        /// Specifies a comma separated list of days of the year. (1,2,365,366,-1,-2,-366)
        /// </summary>
        [Zetbox.API.DefinitionGuid("80d7a3af-ce9f-440b-893a-893e3660d0fc")]
        string ByYearDay {
            get;
            set;
        }


        /// <summary>
        /// Specifies how often the recurrence will be repeated. The start date counts as the first one
        /// </summary>
        [Zetbox.API.DefinitionGuid("7f058fb2-9be2-4a0e-b756-3a998b213056")]
        int? Count {
            get;
            set;
        }


        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("106aaa19-f9aa-4e8e-a803-b06e037b7861")]
        Zetbox.App.Base.Frequency? Frequency {
            get;
            set;
        }


        /// <summary>
        /// Specifies how often the recurrence rule repeats, null is equivalent to 1
        /// </summary>
        [Zetbox.API.DefinitionGuid("aec74e19-3b6c-43b9-b663-0ba73371660f")]
        int? Interval {
            get;
            set;
        }


        /// <summary>
        /// Recurrents ends at this date, including this date
        /// </summary>
        [Zetbox.API.DefinitionGuid("50842a43-7237-46b4-90c9-6d47455c6178")]
        DateTime? Until {
            get;
            set;
        }


        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("be402d16-76bd-4481-b779-dec424802543")]
        Zetbox.App.Base.DayOfWeek? WeekStart {
            get;
            set;
        }


        /// <summary>
        /// 
        /// </summary>
        DateTime GetCurrent(DateTime start);

        /// <summary>
        /// 
        /// </summary>
        DateTime GetCurrent(DateTime start, DateTime dt);

        /// <summary>
        /// 
        /// </summary>
        DateTime GetNext(DateTime start);

        /// <summary>
        /// 
        /// </summary>
        DateTime GetNext(DateTime start, DateTime dt);

        /// <summary>
        /// 
        /// </summary>
        DateTime GetRelative(DateTime dt);

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<DateTime> GetWithinInterval(DateTime start, DateTime from, DateTime until);
    }
}
