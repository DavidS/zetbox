// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.
namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.App.Extensions;
    using Zetbox.API.Utils;
    using System.Text.RegularExpressions;

    [Implementor]
    public class RecurrenceRuleActions
    {
        [Invocation]
        public static void ToString(RecurrenceRule obj, MethodReturnEventArgs<string> e)
        {
            var interval = obj.Interval ?? 1;
            if (interval <= 0)
            {
                interval = 1;
            }

            var sb = new StringBuilder();
            if (obj.Frequency.HasValue) sb.AppendFormat("every {0} {1}", interval, ToString(obj.Frequency.Value));
            if (!string.IsNullOrWhiteSpace(obj.ByMonth)) sb.AppendFormat(" by months {0}", obj.ByMonth);
            if (!string.IsNullOrWhiteSpace(obj.ByWeekNumber)) sb.AppendFormat(" by week numbers {0}", obj.ByWeekNumber);
            if (!string.IsNullOrWhiteSpace(obj.ByYearDay)) sb.AppendFormat(" by year days {0}", obj.ByYearDay);
            if (!string.IsNullOrWhiteSpace(obj.ByMonthDay)) sb.AppendFormat(" by month days {0}", obj.ByMonthDay);
            if (!string.IsNullOrWhiteSpace(obj.ByDay)) sb.AppendFormat(" by days {0}", obj.ByDay);
            if (!string.IsNullOrWhiteSpace(obj.ByHour)) sb.AppendFormat(" by hours {0}", obj.ByHour);
            if (!string.IsNullOrWhiteSpace(obj.ByMinute)) sb.AppendFormat(" by minutes {0}", obj.ByMinute);
            if (!string.IsNullOrWhiteSpace(obj.BySecond)) sb.AppendFormat(" by seconds {0}", obj.BySecond);

            if (obj.Until.HasValue)
            {
                sb.AppendFormat(" until {0}", obj.Until);
            }
            else if (obj.Count.HasValue)
            {
                sb.AppendFormat(" {0} times", obj.Count);
            }

            if (sb.Length == 0)
            {
                sb.Append("not defined");
            }
            e.Result = sb.ToString();
        }

        private static string ToString(Frequency f)
        {
            switch (f)
            {
                case Frequency.Yearly:
                    return "year";
                case Frequency.Monthly:
                    return "month";
                case Frequency.Weekly:
                    return "week";
                case Frequency.Daily:
                    return "day";
                case Frequency.Hourly:
                    return "hour";
                case Frequency.Minutely:
                    return "minue";
                case Frequency.Secondly:
                    return "second";
                default:
                    return string.Empty;
            }
        }

        private static TimeSpan GetIntervalTimeSpan(Frequency? freq, int? interval)
        {
            var i = Math.Abs(interval ?? 1);
            switch (freq)
            {
                case Frequency.Yearly:
                    return new TimeSpan(i * 366, 0, 0, 0);
                case Frequency.Monthly:
                    return new TimeSpan(i * 31, 0, 0, 0);
                case Frequency.Weekly:
                    return new TimeSpan(i * 7, 0, 0, 0);
                case Frequency.Daily:
                    return new TimeSpan(i * 1, 0, 0, 0);
                case Frequency.Hourly:
                    return new TimeSpan(0, i * 1, 0, 0);
                case Frequency.Minutely:
                    return new TimeSpan(0, 0, i * 1, 0);
                case Frequency.Secondly:
                    return new TimeSpan(0, 0, 0, i * 1);
                default:
                    return new TimeSpan(0, 0, 0, 0);
            }
        }

        [Invocation]
        public static void GetNext(RecurrenceRule obj, MethodReturnEventArgs<DateTime> e, DateTime start)
        {
            e.Result = obj.GetNext(start, DateTime.Now);
        }

        [Invocation]
        public static void GetNext(RecurrenceRule obj, MethodReturnEventArgs<DateTime> e, DateTime start, DateTime dt)
        {
            var occurrences = obj.GetWithinInterval(start, dt, dt.Add(GetIntervalTimeSpan(obj.Frequency, obj.Interval)));
            e.Result = occurrences.Where(i => i != dt).FirstOrDefault();
            if (e.Result == default(DateTime)) e.Result = dt;
        }

        [Invocation]
        public static void GetCurrent(RecurrenceRule obj, MethodReturnEventArgs<DateTime> e, DateTime start)
        {
            e.Result = obj.GetCurrent(start, DateTime.Now);
        }

        [Invocation]
        public static void GetCurrent(RecurrenceRule obj, MethodReturnEventArgs<DateTime> e, DateTime start, DateTime dt)
        {
            var occurrences = obj.GetWithinInterval(start, dt.Add(-GetIntervalTimeSpan(obj.Frequency, obj.Interval)), dt);
            e.Result = occurrences.LastOrDefault();
            if (e.Result == default(DateTime)) e.Result = dt;
        }

        public static IEnumerable<int> ToInt(string val)
        {
            if (string.IsNullOrWhiteSpace(val)) throw new ArgumentNullException("val");
            return val
                .Split(',')
                .Select(s =>
                {
                    int r;
                    if (int.TryParse(s, out r))
                        return r;
                    return (int?)null;
                })
                .Where(i => i != null)
                .Select(i => i.Value);
        }

        static Regex weekDayRegEx = new Regex(@"([+-]?\d*)(\w{2})");
        public static IEnumerable<DayOfWeek> ToWeekdays(string val)
        {
            if (string.IsNullOrWhiteSpace(val)) throw new ArgumentNullException("val");
            return val
                .Split(',')
                .Select(s =>
                {
                    var match = weekDayRegEx.Match(s);
                    if (match.Success)
                    {
                        var n_occurence = match.Groups[1].Value;
                        var day = match.Groups[2].Value;
                        switch (day)
                        {
                            case "MO":
                                return DayOfWeek.Monday;
                            case "TU":
                                return DayOfWeek.Tuesday;
                            case "WE":
                                return DayOfWeek.Wednesday;
                            case "TH":
                                return DayOfWeek.Thursday;
                            case "FR":
                                return DayOfWeek.Friday;
                            case "SA":
                                return DayOfWeek.Saturday;
                            case "SU":
                                return DayOfWeek.Sunday;
                        }
                    }
                    return (DayOfWeek?)null;
                })
                .Where(i => i != null)
                .Select(i => i.Value);
        }

        [Invocation]
        public static void GetWithinInterval(RecurrenceRule obj, MethodReturnEventArgs<IEnumerable<DateTime>> e, DateTime start, DateTime from, DateTime until)
        {
            if (obj.Frequency == null)
            {
                e.Result = Enumerable.Empty<DateTime>();
                return;
            }
            var interval = obj.Interval ?? 1;
            if (interval <= 0)
            {
                Logging.Log.WarnFormat("{0} has an invalid interval of {1}", obj, interval);
                interval = 1;
            }


            var result = new List<DateTime>();
            var current = start;
            AddToResult(result, current, from, until);

            while (current <= until)
            {

                switch (obj.Frequency.Value)
                {
                    case Frequency.Yearly:
                        current = current.AddYears(interval);
                        AddToResult(result, current, from, until);
                        break;
                    case Frequency.Monthly:
                        current = current.AddMonths(interval);
                        if (obj.ByMonthDay != null)
                        {
                            foreach (var day in ToInt(obj.ByMonthDay))
                            {
                                if (day >= 0)
                                {
                                    AddToResult(result, current.FirstMonthDay().AddDays(day - 1), from, until);
                                }
                                else
                                {
                                    AddToResult(result, current.LastMonthDay().AddDays(day + 1), from, until);
                                }
                            }
                        }
                        else
                        {
                            AddToResult(result, current, from, until);
                        }
                        break;
                    case Frequency.Weekly:
                        current = current.AddDays(interval * 7);
                        if (obj.ByDay != null)
                        {
                            foreach (var wd in ToWeekdays(obj.ByDay))
                            {
                                AddToResult(result, current.FirstWeekDay().AddDays((((int)wd - 1) % 7)), from, until);
                            }
                        }
                        else
                        {
                            AddToResult(result, current, from, until);
                        }
                        break;
                    case Frequency.Daily:
                        current = current.AddDays(interval);
                        AddToResult(result, current, from, until);
                        break;
                    case Frequency.Hourly:
                        current = current.AddHours(interval);
                        AddToResult(result, current, from, until);
                        break;
                    case Frequency.Minutely:
                        current = current.AddMinutes(interval);
                        AddToResult(result, current, from, until);
                        break;
                    case Frequency.Secondly:
                        current = current.AddSeconds(interval);
                        AddToResult(result, current, from, until);
                        break;
                    default:
                        break;
                }
            }

            e.Result = result;
        }

        private static void AddToResult(List<DateTime> result, DateTime current, DateTime start, DateTime until)
        {
            if (current >= start && current <= until)
            {
                result.Add(current);
            }
        }
    }
}
