﻿using System;
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
using Zetbox.Client.GUI;
using Zetbox.Client.Presentables.Calendar;

namespace Zetbox.Client.WPF.View.Calendar
{
    /// <summary>
    /// Interaction logic for NextEventsSummaryDisplay.xaml
    /// </summary>
    [ViewDescriptor(Zetbox.App.GUI.Toolkit.WPF)]
    public partial class NextEventsSummaryDisplay : UserControl, IHasViewModel<NextEventsSummaryViewModel>
    {
        public NextEventsSummaryDisplay()
        {
            InitializeComponent();
        }

        public NextEventsSummaryViewModel ViewModel
        {
            get { return (NextEventsSummaryViewModel)DataContext; }
        }
    }
}