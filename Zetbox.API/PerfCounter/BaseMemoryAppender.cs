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
namespace Zetbox.API.PerfCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Autofac;
    using Zetbox.API;
    using Zetbox.API.Configuration;
    using Zetbox.API.Utils;
    using log4net;

    public sealed class MethodMemoryCounters
    {
        public readonly string Name;
        public MethodMemoryCounters(string name)
        {
            this.Name = name;
            Reset();
        }

        public long Duration { get; private set; }
        public long Objects { get; private set; }
        public long Calls { get; private set; }
        public long MinDuration { get; private set; }
        public long MaxDuration { get; private set; }

        internal void Reset()
        {
            this.Duration =
                this.Objects =
                this.Calls = 0;
            this.MinDuration = long.MinValue;
            this.MaxDuration = long.MaxValue;
        }

        internal void Count(int objectCount, long startTicks, long endTicks)
        {
            Calls += 1;
            Objects += objectCount;
            var thisDuration = endTicks - startTicks;
            Duration += thisDuration;
            if (thisDuration < MinDuration)
            {
                MinDuration = thisDuration;
            }
            else if (thisDuration > MaxDuration)
            {
                MaxDuration = thisDuration;
            }
        }

        internal void FormatTo(Dictionary<string, string> values)
        {
            values[Name + "Calls"] = Calls.ToString();
            values[Name + "Objects"] = Objects.ToString();
            values[Name + "Duration"] = BaseMemoryAppender.TicksToMillis(Duration).ToString();
            values[Name + "AvgDuration"] = BaseMemoryAppender.Avg(Duration, Calls).ToString();
            if (MinDuration != long.MinValue)
                values[Name + "MinDuration"] = MinDuration.ToString();
            if (MaxDuration != long.MaxValue)
                values[Name + "MaxDuration"] = MaxDuration.ToString();
        }
    }

    public abstract class BaseMemoryAppender : IBasePerfCounterAppender
    {
        protected static readonly object counterLock = new object();

        #region static utilities

        public static long Avg(long duration, long count)
        {
            return count != 0 ? duration * 1000 / count / System.Diagnostics.Stopwatch.Frequency : 0;
        }

        public static long TicksToMillis(long p)
        {
            return p * 1000 / System.Diagnostics.Stopwatch.Frequency;
        }

        #endregion

        #region Counters

        protected readonly ObjectMemoryCounters ObjectTotals = new ObjectMemoryCounters("Totals");
        protected readonly MethodMemoryCounters SetObjects = new MethodMemoryCounters("SetObjects");
        protected readonly MethodMemoryCounters SubmitChanges = new MethodMemoryCounters("SubmitChanges");

        protected long ServerMethodInvocation { get; private set; }

        #endregion

        public BaseMemoryAppender()
        {
            this.Objects = new Dictionary<string, ObjectMemoryCounters>();
        }

        public void Install()
        {
        }

        public void Uninstall()
        {
        }

        protected List<string> allClasses;
        public void Initialize(IFrozenContext frozenCtx)
        {
            try
            {
                allClasses = GetAllClassNames(frozenCtx);
                ApplyObjectsTemplate();
            }
            catch (Exception ex)
            {
                Logging.Log.Error("Error initializing PerfMon Memory Appender", ex);
            }
        }

        public abstract void Dump(bool force);

        protected virtual void ResetValues()
        {
            lock (counterLock)
            {
                this.ObjectTotals.Reset();
                this.SetObjects.Reset();
                this.SubmitChanges.Reset();
                this.ServerMethodInvocation = 0;
                this.Objects.Clear();
                ApplyObjectsTemplate();
            }
        }

        private void ApplyObjectsTemplate()
        {
            if (allClasses != null)
            {
                foreach (var name in allClasses)
                {
                    this.Objects[name] = new ObjectMemoryCounters(name);
                }
            }
        }

        protected abstract List<string> GetAllClassNames(IFrozenContext frozenCtx);

        protected Dictionary<string, ObjectMemoryCounters> Objects { get; private set; }

        private ObjectMemoryCounters Get(InterfaceType ifType)
        {
            var name = ifType.Type.FullName;
            ObjectMemoryCounters result;
            if (!Objects.TryGetValue(name, out result))
            {
                result = new ObjectMemoryCounters(name);
                Objects[name] = result;
            }
            return result;
        }

        public void IncrementFetchRelation(InterfaceType ifType)
        {
        }
        public void DecrementFetchRelation(InterfaceType ifType, int resultSize, long startTicks, long endTicks)
        {
            lock (counterLock)
            {
                this.ObjectTotals.FetchRelation.Count(resultSize, startTicks, endTicks);
                Get(ifType).FetchRelation.Count(resultSize, startTicks, endTicks);
                Dump(false);
            }
        }

        public void IncrementGetObjects(InterfaceType ifType)
        {
        }
        public void DecrementGetObjects(InterfaceType ifType, int resultSize, long startTicks, long endTicks)
        {
            lock (counterLock)
            {
                this.ObjectTotals.GetList.Count(resultSize, startTicks, endTicks);
                Get(ifType).GetList.Count(resultSize, startTicks, endTicks);
                Dump(false);
            }
        }

        public void IncrementGetListOf(InterfaceType ifType)
        {
        }
        public void DecrementGetListOf(InterfaceType ifType, int resultSize, long startTicks, long endTicks)
        {
            lock (counterLock)
            {
                this.ObjectTotals.GetListOf.Count(resultSize, startTicks, endTicks);
                Get(ifType).GetListOf.Count(resultSize, startTicks, endTicks);
                Dump(false);
            }
        }

        public void IncrementQuery(InterfaceType ifType)
        {
        }
        public void DecrementQuery(InterfaceType ifType, int resultSize, long startTicks, long endTicks)
        {
            lock (counterLock)
            {
                this.ObjectTotals.Queries.Count(resultSize, startTicks, endTicks);
                Get(ifType).Queries.Count(resultSize, startTicks, endTicks);
                Dump(false);
            }
        }


        public void IncrementSubmitChanges()
        {
        }
        public void DecrementSubmitChanges(int objectCount, long startTicks, long endTicks)
        {
            lock (counterLock)
            {
                this.SubmitChanges.Count(objectCount, startTicks, endTicks);
                Dump(false);
            }
        }

        public void IncrementSetObjects()
        {
        }
        public void DecrementSetObjects(int objectCount, long startTicks, long endTicks)
        {
            lock (counterLock)
            {
                this.SetObjects.Count(objectCount, startTicks, endTicks);
                Dump(false);
            }
        }

        public void IncrementServerMethodInvocation()
        {
            lock (counterLock)
            {
                ServerMethodInvocation++;

                Dump(false);
            }
        }

        public virtual void FormatTo(Dictionary<string, string> values)
        {
            this.ObjectTotals.FormatTo(values);
            this.SubmitChanges.FormatTo(values);
            this.SetObjects.FormatTo(values);
            values["ServerMethodInvocations"] = ServerMethodInvocation.ToString();

            // does not format per-Object counts
        }
    }
}
