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
namespace Zetbox.Client.Presentables
{
    using System;
    using Zetbox.Client.Presentables.ValueViewModels;
    using System.Linq;
    using System.Collections.Generic;

    public interface IValueInputTaskViewModel
    {
        void Cancel();
        ICommandViewModel CancelCommand { get; }
        void Invoke();
        ICommandViewModel InvokeCommand { get; }
        string Name { get; }
        IEnumerable<ViewModel> ValueViewModels { get; }
        ILookup<object, ViewModel> ValueViewModelsByName { get; }
    }
}
