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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Zetbox.Client.GUI;
using Zetbox.Client.Presentables.DocumentManagement;
using Zetbox.Client.WPF.Toolkit;

namespace Zetbox.Client.WPF.View.DocumentManagement
{
    /// <summary>
    /// Interaction logic for ImageEditor.xaml
    /// </summary>
    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public partial class ImportedFileWithPreviewEditor : PreviewEditor, IHasViewModel<ImportedFileViewModel>
    {
        public ImportedFileWithPreviewEditor()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        protected override ContentPresenter PreviewControl
        {
            get { return preview; }
        }

        public new ImportedFileViewModel ViewModel
        {
            get { return (ImportedFileViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }
    }
}
