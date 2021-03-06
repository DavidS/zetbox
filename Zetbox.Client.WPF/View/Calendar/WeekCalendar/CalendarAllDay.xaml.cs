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
using Zetbox.Client.GUI;
using Zetbox.Client.Presentables.Calendar;
using Zetbox.Client.WPF.Toolkit;

namespace Zetbox.Client.WPF.View.Calendar
{
    /// <summary>
    /// Interaction logic for CalendarAllDay.xaml
    /// </summary>
    public partial class CalendarAllDay : UserControl, IHasViewModel<DayCalendarViewModel>
    {
        public CalendarAllDay()
        {
            InitializeComponent();
        }

        private void CalendarItem_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement)
            {
                var fe = (FrameworkElement)sender;
                var vmdl = fe.DataContext as CalendarItemViewModel;
                if (vmdl != null)
                {
                    if (e.ClickCount == 1)
                    {
                        ViewModel.WeekCalendar.SelectedItem = vmdl.EventViewModel;
                    }
                    else if (e.ClickCount == 2)
                    {
                        ViewModel.WeekCalendar.NotifyOpen(vmdl.EventViewModel);
                    }
                }
            }
            e.Handled = true;
        }

        private void Empty_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement)
            {
                if (e.ClickCount == 1)
                {
                    ViewModel.WeekCalendar.SelectedItem = null;
                }
                else if (e.ClickCount == 2)
                {
                    ViewModel.WeekCalendar.NotifyNew(ViewModel.Day, true);
                }
            }
        }

        #region IHasViewModel<DayCalendarViewModel> Members

        public DayCalendarViewModel ViewModel
        {
            get { return (DayCalendarViewModel)WPFHelper.SanitizeDataContext(DataContext); }
        }

        #endregion
    }
}
