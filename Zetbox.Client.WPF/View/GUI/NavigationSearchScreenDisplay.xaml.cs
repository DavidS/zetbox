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
using Zetbox.Client.Presentables.GUI;

namespace Zetbox.Client.WPF.View.GUI
{
    /// <summary>
    /// Interaction logic for SearchScreenDisplay.xaml
    /// </summary>
    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public partial class NavigationSearchScreenDisplay : UserControl, IHasViewModel<NavigationSearchScreenViewModel>
    {
        public NavigationSearchScreenDisplay()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }

        #region IHasViewModel<SearchScreenViewModel> Members

        public NavigationSearchScreenViewModel ViewModel
        {
            get { return (NavigationSearchScreenViewModel)DataContext; }
        }

        #endregion
    }
}
