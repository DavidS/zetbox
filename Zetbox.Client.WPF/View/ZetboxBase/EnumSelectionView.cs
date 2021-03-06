﻿// This file is part of zetbox.
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
using Zetbox.Client.Presentables;
using Zetbox.Client.Presentables.ValueViewModels;
using Zetbox.Client.WPF.CustomControls;
using Zetbox.Client.WPF.Toolkit;
using Zetbox.Client.WPF.View.ZetboxBase;

namespace Zetbox.Client.WPF.View
{

    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public class EnumSelectionView : PropertyEditor, IHasViewModel<EnumerationValueViewModel>
    {
        static EnumSelectionView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EnumSelectionView), new FrameworkPropertyMetadata(typeof(EnumSelectionView)));
        }

        ComboBox cb;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            cb = (ComboBox)GetTemplateChild("PART_cb");
            cb.KeyDown += cbValue_KeyDown;
            SetupFocusManagement(cb, () => ViewModel);
        }

        #region IHasViewModel<EnumerationPropertyModel> Members

        public EnumerationValueViewModel ViewModel
        {
            get { return (EnumerationValueViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }

        #endregion

        protected override FrameworkElement MainControl
        {
            get { return (FrameworkElement)GetTemplateChild("PART_cb"); }
        }

        private void cbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                ViewModel.FormattedValue = cb.Text;
            }
        }
    }
}
