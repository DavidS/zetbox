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
using Zetbox.Client.Models;
using Zetbox.Client.Presentables;
using Zetbox.Client.Presentables.ValueViewModels;
using Zetbox.Client.WPF.CustomControls;

namespace Zetbox.Client.WPF.View.ZetboxBase
{
    /// <summary>
    /// Interaction logic for ObjectReferenceEditor.xaml
    /// </summary>
    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public partial class ObjectReferenceDropdownEditor : PropertyEditor, IHasViewModel<ObjectReferenceViewModel>
    {
        public ObjectReferenceDropdownEditor()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }


        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            //if (e.Property == FrameworkElement.DataContextProperty)
            //{
            //    RefreshGridView();
            //}
        }

        #region IHasViewModel<ObjectReferenceViewModel> Members

        public ObjectReferenceViewModel ViewModel
        {
            get { return (ObjectReferenceViewModel)DataContext; }
        }

        #endregion

        protected override FrameworkElement MainControl
        {
            get { return cbValue; }
        }

        protected override void SetHighlightValue(FrameworkElement ctrl, DependencyProperty dpProp, Highlight h, Converter.HighlightConverter converter, TypeConverter finalConverter)
        {
            if (dpProp != BackgroundProperty) base.SetHighlightValue(ctrl, dpProp, h, converter, finalConverter);
        }

        private void cbValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                ViewModel.ResetPossibleValues();
                cbValue.IsDropDownOpen = true;
            }
        }
    }
}
