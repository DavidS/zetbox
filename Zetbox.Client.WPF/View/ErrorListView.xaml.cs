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

namespace Zetbox.Client.WPF.View
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Shapes;
    using Zetbox.Client.GUI;
    using Zetbox.Client.Presentables;
    using Zetbox.Client.WPF.CustomControls;
    using Zetbox.Client.WPF.Toolkit;

    /// <summary>
    /// Interaction logic for ErrorListView.xaml
    /// </summary>
    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public partial class ErrorListView : WindowView, IHasViewModel<ErrorListViewModel>
    {
        public ErrorListView()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        #region IHasViewModel<ErrorListViewModel> Members

        public ErrorListViewModel ViewModel
        {
            get { return (ErrorListViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }

        #endregion
    }
}
