using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalendarApp
{
    /// <summary>
    /// Interaction logic for WeekWindow.xaml
    /// </summary>
    public partial class WeekWindow : Window
    {
        private int weekLength = 7;

        public WeekWindow()
        {
            System.Globalization.Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            InitializeComponent();
            MainWindow.CalendarDate = DateTime.Now;
            UpdateWeekView();
        }

        public void UpdateWeekView()
        {
            WeekView.Children.Clear();
            DayNumbers.Children.Clear();
            UpdateTitle();
            UpdateDayNumbers();
        }

        private void NextWeekClick(object sender, RoutedEventArgs e)
        {
            MainWindow.CalendarDate = MainWindow.CalendarDate.AddDays(weekLength);
            UpdateWeekView();
        }

        private void PreviousWeekClick(object sender, RoutedEventArgs e)
        {
            MainWindow.CalendarDate = MainWindow.CalendarDate.AddDays(-weekLength);
            UpdateWeekView();
        }

        private void UpdateDayNumbers()
        {
            int sunday = 7;
            int dayOffset = 1;
            DateTime dayTracker = MainWindow.CalendarDate;
            int dayOfWeek = (int)dayTracker.DayOfWeek;
            dayTracker = dayTracker.AddDays(-dayOfWeek + dayOffset);
            System.Diagnostics.Debug.WriteLine(dayOfWeek);
            if (dayOfWeek == 0)
            {
                dayOfWeek = sunday;
            }
            int start = 1;
            for (int i = start; i < weekLength+1; i++)
            {
                int dayOfPosition = dayTracker.Day;
                System.Diagnostics.Debug.WriteLine(dayOfPosition);
                int rowPosition = 0;
                TextBlock dayNumber = new TextBlock();
                dayNumber.Text = dayOfPosition.ToString();
                dayNumber.SetValue(Grid.RowProperty, rowPosition);
                dayNumber.SetValue(Grid.ColumnProperty, i);
                DayNumbers.Children.Add(dayNumber);
                dayTracker = dayTracker.AddDays(1); 
            }
        }

        private void UpdateTitle()
        {
            string title = MainWindow.CalendarDate.ToString("MMMM") + " " + MainWindow.CalendarDate.Year;
            Title.Text = title;
        }
    }
}
