using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zetbox.Client.Presentables;
using Zetbox.Client.Presentables.ValueViewModels;

namespace Zetbox.Client.Forms.View
{
    public partial class DataObjectListView : DataObjectListViewDesignerProxy
    {
        public DataObjectListView()
        {
            InitializeComponent();
        }

        protected override void OnDataContextChanged()
        {
            base.OnDataContextChanged();
            SyncLabel();
        }

        protected override void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnModelPropertyChanged(sender, e);
            if (e.PropertyName == "Label")
                SyncLabel();
        }

        private void SyncLabel()
        {
            _label.Text = DataContext.Label;
        }
    }

    public class DataObjectListViewDesignerProxy : FormsUserControl<ObjectListViewModel> { }
}
