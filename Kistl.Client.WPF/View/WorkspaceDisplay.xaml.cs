
namespace Kistl.Client.WPF.View
{
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

    using Kistl.API.Client;
    using Kistl.Client.Presentables;

    /// <summary>
    /// Interaction logic for WorkspaceDisplay.xaml, a read-only display of a <see cref="Kistl.Client.Presentables.WorkspaceModel"/>.
    /// </summary>
    public partial class WorkspaceDisplay : Window
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceDisplay class.
        /// </summary>
        public WorkspaceDisplay()
        {
            InitializeComponent();
        }

        private void ModuleTreeSelectedItemChangedHandler(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var item = ObjectTree.SelectedItem as Kistl.Client.Presentables.PresentableModel;
            if (item != null)
            {
                this.Model.SelectedItem = item;
            }
        }

        /// <summary>
        /// Gets or sets the displayed model. Uses the DataContext as backing store.
        /// </summary>
        private Kistl.Client.Presentables.WorkspaceModel Model
        {
            get { return (Kistl.Client.Presentables.WorkspaceModel)DataContext; }
        }
    }
}
