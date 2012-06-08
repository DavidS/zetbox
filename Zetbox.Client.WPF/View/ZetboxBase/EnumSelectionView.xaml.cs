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
using Zetbox.Client.WPF.View.ZetboxBase;

namespace Zetbox.Client.WPF.View
{
    /// <summary>
    /// Interaction logic for EnumSelectionView.xaml
    /// </summary>
    public partial class EnumSelectionView : PropertyEditor, IHasViewModel<EnumerationValueViewModel>
    {
        public EnumSelectionView()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();

            cb.GotKeyboardFocus += (s, e) => ViewModel.Focus();
            cb.LostKeyboardFocus += (s, e) => ViewModel.Blur();
        }

        #region IHasViewModel<EnumerationPropertyModel> Members

        public EnumerationValueViewModel ViewModel
        {
            get { return (EnumerationValueViewModel)DataContext; }
        }

        #endregion

        protected override FrameworkElement MainControl
        {
            get { return cb; }
        }

        protected override void SetHighlightValue(FrameworkElement ctrl, DependencyProperty dpProp, Highlight h, Converter.HighlightConverter converter, TypeConverter finalConverter)
        {
            if(dpProp != BackgroundProperty) base.SetHighlightValue(ctrl, dpProp, h, converter, finalConverter);
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
