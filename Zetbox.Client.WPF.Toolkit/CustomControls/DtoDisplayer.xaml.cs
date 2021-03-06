// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.Client.WPF.CustomControls
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
    using Zetbox.Client.Presentables.DtoViewModels;
    using Zetbox.Client.WPF.Toolkit;
    using System.ComponentModel;

    public class DtoOverlayGrid : Grid, INotifyPropertyChanged
    {
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);

            if (e.Property == Grid.IsMouseOverProperty)
            {
                _isMouseOver = (bool)e.NewValue;
                OnPropertyChanged("ShowLayer");
                var parent = VisualTreeHelper.GetParent(this);
                while (parent != null)
                {
                    if (parent is DtoOverlayGrid)
                    {
                        var dtoOverlayGrid = (DtoOverlayGrid)parent;
                        dtoOverlayGrid.SetStop(_isMouseOver);
                        break;
                    }
                    parent = VisualTreeHelper.GetParent(parent);
                }
            }
        }

        private bool _isMouseOver = false;
        private bool _stop = false;
        
        protected void SetStop(bool value)
        {
            _stop = value;
            OnPropertyChanged("ShowLayer");
        }

        public bool ShowLayer
        {
            get 
            {
                return _isMouseOver && !_stop;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string name)
        {
            var temp = PropertyChanged;
            if (temp != null)
            {
                temp(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    /// <summary>
    /// Interaction logic for DtoDisplayer.xaml
    /// </summary>
    public partial class DtoDisplayer : UserControl
    {
        public DtoDisplayer()
        {
            InitializeComponent();
        }

        public void Grid_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null && WPFHelper.SanitizeDataContext(e.NewValue) != null)
                InitGrid(grid, e.NewValue as DtoTableViewModel);
        }

        public void Grid_Initialized(object sender, EventArgs e)
        {
            var grid = sender as Grid;
            if (grid != null)
                InitGrid(grid, grid.DataContext as DtoTableViewModel);
        }

        private static void InitGrid(Grid grid, DtoTableViewModel vm)
        {
            if (vm != null && grid != null)
            {
                grid.RowDefinitions.Clear();
                grid.ColumnDefinitions.Clear();
                foreach (var row in vm.Rows)
                {
                    grid.RowDefinitions.Add(new RowDefinition());
                }
                foreach (var col in vm.Columns)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition() { SharedSizeGroup = "col" + col.Column.ToString() });
                }

                grid.InvalidateArrange();
                grid.UpdateLayout();
            }
        }
    }
}
