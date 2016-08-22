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
    using Autofac;
    using Zetbox.API.PerfCounter;

    public interface IPerfCounter : IBasePerfCounter
    {
        void IncrementViewModel();
        void DecrementViewModel();

        void IncrementViewModelFetch();
        void IncrementViewModelCreate();
    }

    public interface IPerfCounterAppender : IBasePerfCounterAppender
    {
        void IncrementViewModel();
        void DecrementViewModel();

        void IncrementViewModelFetch();
        void IncrementViewModelCreate();
    }

    public static class LifetimeScopeExtensions
    {
        public static void ApplyPerfCounterTracker(this ILifetimeScope scope)
        {
            scope.ChildLifetimeScopeBeginning += (s, a) => a.LifetimeScope.ApplyPerfCounterTracker();
            var perfCtr = scope.Resolve<IPerfCounter>();
            var startTicks = perfCtr.IncrementLifetimeScope();
            scope.CurrentScopeEnding += (s, a) => perfCtr.DecrementLifetimeScope(startTicks);
        }
    }
}
