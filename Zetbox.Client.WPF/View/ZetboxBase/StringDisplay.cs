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

namespace Zetbox.Client.WPF.View.ZetboxBase
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
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using Zetbox.Client.GUI;
    using Zetbox.Client.Presentables.ValueViewModels;
    using Zetbox.Client.WPF.Converter;
    using Zetbox.Client.WPF.CustomControls;
    using Zetbox.Client.WPF.Toolkit;
    using Zetbox.Client.Presentables;

    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public class StringDisplay : TextBlock, IHasViewModel<ViewModel> // Simplify, often used Control
    {
        //    <TextBlock x:Name="txtStringDisplay"
        //               Text="{Binding Name, Mode=OneWay}"
        //               ToolTip="{Binding ToolTip}" />

        public StringDisplay()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;

            // InitializeComponent
            this.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            // Don't wrap - use a property in viewmodel instead
            // this.TextWrapping = System.Windows.TextWrapping.Wrap;

            BindingOperations.SetBinding(this, TextBlock.TextProperty, new Binding("Name") { Mode = BindingMode.OneWay });
            BindingOperations.SetBinding(this, TextBlock.ToolTipProperty, new Binding("ToolTip") { Mode = BindingMode.OneWay });
            BindingOperations.SetBinding(this, Zetbox.Client.WPF.Styles.Controls.HighlightProperty, new Binding("HighlightAsync") { Mode = BindingMode.OneWay });
        }

        public ViewModel ViewModel
        {
            get { return (ViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }
    }

    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public class TextDisplay : TextBlock, IHasViewModel<TextViewModel> // Simplify, often used Control
    {
        //    <TextBlock x:Name="txtStringDisplay"
        //               Text="{Binding Name, Mode=OneWay}"
        //               ToolTip="{Binding ToolTip}" />

        public TextDisplay()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;

            // InitializeComponent
            this.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            // Don't wrap - use a property in viewmodel instead
            // this.TextWrapping = System.Windows.TextWrapping.Wrap;

            BindingOperations.SetBinding(this, TextBlock.TextProperty, new Binding("Text") { Mode = BindingMode.OneWay });
            BindingOperations.SetBinding(this, FontWeightProperty, new Binding("Bold") { Mode = BindingMode.OneWay, Converter = (IValueConverter)FindResource("FormattingToFontWeightConverter") });
            BindingOperations.SetBinding(this, TextBlock.ToolTipProperty, new Binding("ToolTip") { Mode = BindingMode.OneWay });
            BindingOperations.SetBinding(this, Zetbox.Client.WPF.Styles.Controls.HighlightProperty, new Binding("HighlightAsync") { Mode = BindingMode.OneWay });
        }

        public TextViewModel ViewModel
        {
            get { return (TextViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }
    }

    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public class StringValueDisplay : TextBlock, IHasViewModel<IFormattedValueViewModel> // Simplify, often used Control
    {
        //    <TextBlock x:Name="txtStringDisplay"
        //               Text="{Binding FormattedValue, Mode=OneWay}"
        //               ToolTip="{Binding ToolTip}" />

        public StringValueDisplay()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;

            // InitializeComponent
            this.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            // Don't wrap - use a property in viewmodel instead
            // this.TextWrapping = System.Windows.TextWrapping.Wrap;

            BindingOperations.SetBinding(this, TextBlock.TextProperty, new Binding("FormattedValueAsync") { Mode = BindingMode.OneWay });
            BindingOperations.SetBinding(this, TextBlock.ToolTipProperty, new Binding("ToolTip") { Mode = BindingMode.OneWay });
            BindingOperations.SetBinding(this, Zetbox.Client.WPF.Styles.Controls.HighlightProperty, new Binding("HighlightAsync") { Mode = BindingMode.OneWay });
        }

        public IFormattedValueViewModel ViewModel
        {
            get { return (IFormattedValueViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }
    }
}
