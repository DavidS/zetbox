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

namespace Zetbox.App.Projekte.Client.ViewModel.Projekte
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.App.GUI;
    using Zetbox.Client.Presentables;
    using Zetbox.Client.Presentables.Calendar;

    [ViewModelDescriptor]
    public class TaskViewModel : DataObjectViewModel
    {
        public new delegate TaskViewModel Factory(IZetboxContext dataCtx, ViewModel parent, Task obj);

        public TaskViewModel(IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent, Task obj)
            : base(appCtx, dataCtx, parent, obj)
        {
        }

        public Task Task
        {
            get
            {
                return (Task)base.Object;
            }
        }

        public override string Name
        {
            get { return Task.Name; }
        }
    }
}
