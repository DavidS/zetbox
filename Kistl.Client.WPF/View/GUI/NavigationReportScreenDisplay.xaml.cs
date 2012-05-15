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
using Kistl.Client.GUI;
using Kistl.Client.Presentables.GUI;

namespace Kistl.Client.WPF.View.GUI
{
    /// <summary>
    /// Interaction logic for ReportScreenDisplay.xaml
    /// </summary>
    [ViewDescriptor(Kistl.App.GUI.Toolkit.WPF)]
    public partial class NavigationReportScreenDisplay : UserControl, IHasViewModel<NavigationReportScreenViewModel>
    {
        public NavigationReportScreenDisplay()
        {
            InitializeComponent();
        }

        public NavigationReportScreenViewModel ViewModel
        {
            get { return (NavigationReportScreenViewModel)DataContext; }
        }
    }
}