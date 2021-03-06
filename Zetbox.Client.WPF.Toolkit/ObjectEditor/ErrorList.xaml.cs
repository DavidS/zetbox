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
using Zetbox.Client.Presentables.ObjectEditor;

namespace Zetbox.Client.WPF.ObjectEditor
{
    /// <summary>
    /// Interaction logic for ErrorList.xaml
    /// </summary>
    public partial class ErrorList : UserControl, IHasViewModel<WorkspaceViewModel>
    {
        public ErrorList()
        {
            InitializeComponent();
        }

        public WorkspaceViewModel ViewModel
        {
            get { return (WorkspaceViewModel)DataContext; }
        }
    }
}
