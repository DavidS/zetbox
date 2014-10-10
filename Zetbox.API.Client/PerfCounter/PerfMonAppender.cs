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
namespace Zetbox.API.Client.PerfCounter
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using Autofac;
    using Zetbox.API;
    using Zetbox.API.PerfCounter;
    using Zetbox.API.Utils;
    using Zetbox.API.Configuration;
    using System.ComponentModel;

    public class PerfMonAppender : BasePerfMonAppender, IPerfCounterAppender
    {
        [Feature]
        [Description("PerfCounter writing to the Windows Performance Monitor")]
        public class Module : Autofac.Module
        {
            protected override void Load(ContainerBuilder moduleBuilder)
            {
                base.Load(moduleBuilder);

                moduleBuilder
                    .RegisterType<PerfMonAppender>()
                    .As<IPerfCounterAppender>()
                    .OnActivated(args => args.Instance.Initialize(args.Context.Resolve<IFrozenContext>()))
                    .SingleInstance();
            }
        }

        public override string Category { get { return "Zetbox Client"; } }

        public PerfMonAppender(Configuration.ZetboxConfig cfg)
            : base(cfg)
        {
        }

        protected override CounterDesc[] CounterDesciptors
        {
            get { return _counterDescs; }
        }

        private static readonly CounterDesc[] _counterDescs = new[] 
        { 
            new CounterDesc("ViewModelFetchPerSec", "# of ViewModels fetched / sec.", PerformanceCounterType.RateOfCountsPerSecond32, (pma, desc) => ((PerfMonAppender)pma)._ViewModelFetchPerSec = desc.Get(pma)),
            new CounterDesc("ViewModelFetchTotal", "# of ViewModels fetched.", PerformanceCounterType.NumberOfItems64, (pma, desc) => ((PerfMonAppender)pma)._ViewModelFetchTotal = desc.Get(pma)),
            new CounterDesc("ViewModelCreatePerSec", "# of ViewModels created / sec.", PerformanceCounterType.RateOfCountsPerSecond32, (pma, desc) => ((PerfMonAppender)pma)._ViewModelCreatePerSec = desc.Get(pma)),
            new CounterDesc("ViewModelCreateTotal", "# of ViewModels created.", PerformanceCounterType.NumberOfItems64, (pma, desc) => ((PerfMonAppender)pma)._ViewModelCreateTotal = desc.Get(pma)),
        };

        protected override MethodPerformanceCounter.Desc[] MethodCounterDesciptors
        {
            get { return _methodDescs; }
        }

        private MethodPerformanceCounter.Desc[] _methodDescs = new MethodPerformanceCounter.Desc[] 
        {
        };

        protected override InstancePerformanceCounter.Desc[] InstanceCounterDesciptors
        {
            get { return _instanceDescs; }
        }

        private InstancePerformanceCounter.Desc[] _instanceDescs = new InstancePerformanceCounter.Desc[] 
        {
        };

        PerformanceCounter _ViewModelFetchPerSec;
        PerformanceCounter _ViewModelFetchTotal;
        public void IncrementViewModelFetch()
        {
            if (!initialized) return;
            _ViewModelFetchPerSec.Increment();
            _ViewModelFetchTotal.Increment();
        }

        PerformanceCounter _ViewModelCreatePerSec;
        PerformanceCounter _ViewModelCreateTotal;
        public void IncrementViewModelCreate()
        {
            if (!initialized) return;
            _ViewModelCreatePerSec.Increment();
            _ViewModelCreateTotal.Increment();
        }
    }
}
