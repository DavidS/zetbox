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

namespace Zetbox.Client.WPF.View.TimeRecords
{
    /// <summary>
    /// Interaction logic for WorkEffortView.xaml
    /// </summary>
    public partial class WorkEffortView : UserControl
    {
        public WorkEffortView()
        {
            if (DesignerProperties.GetIsInDesignMode(this)) return;
            InitializeComponent();
        }
    }
}
