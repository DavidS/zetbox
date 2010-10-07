using System;
using System.Collections.Generic;
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
using Kistl.Client.Presentables;
using Kistl.Client.GUI;

namespace Kistl.Client.WPF.View.KistlBase
{
    /// <summary>
    /// Interaction logic for ActionView.xaml
    /// </summary>
    public partial class ActionDisplay : UserControl, IHasViewModel<ActionViewModel>
    {
        public ActionDisplay()
        {
            InitializeComponent();
        }

        private void ClickHandler(object sender, RoutedEventArgs e)
        {
            ViewModel.Execute(null);
        }

        public ActionViewModel ViewModel
        {
            get { return (ActionViewModel)DataContext; }
        }
    }
}
