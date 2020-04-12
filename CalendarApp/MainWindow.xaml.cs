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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime CalendarDate;

        public MainWindow()
        {
            System.Globalization.Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            InitializeComponent();
            CalendarDate = DateTime.Now;
            SetCalendar();
        }

        public void SetCalendar()
        {
            MonthView.Children.Clear();
            SetTitle();
            SetRectangle();
            SetDayNumbers();
        }

        private void NextClick(object sender, RoutedEventArgs e)
        {
            CalendarDate = CalendarDate.AddMonths(1);
            SetCalendar();
        }

        private void PreviousClick(object sender, RoutedEventArgs e)
        {
            CalendarDate = CalendarDate.AddMonths(-1);
            SetCalendar();
        }

        private void SetRectangle()
        {
            Rectangle weekendHighlight = new Rectangle();
            weekendHighlight.SetValue(Grid.RowProperty, 0);
            weekendHighlight.SetValue(Grid.ColumnProperty, 5);
            weekendHighlight.SetValue(Grid.RowSpanProperty, 6);
            weekendHighlight.SetValue(Grid.ColumnSpanProperty, 2);
            SolidColorBrush rectangleColourFill = new SolidColorBrush();
            rectangleColourFill.Color = Color.FromArgb(100, 127, 255, 212);
            weekendHighlight.SetValue(Shape.FillProperty, rectangleColourFill);
            MonthView.Children.Add(weekendHighlight);
        }

        private void SetDayNumbers()
        {
            int sunday = 6;
            int year = CalendarDate.Year;
            int month = CalendarDate.Month;
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int firstDayOfWeek = (int)firstDayOfMonth.DayOfWeek;
            if (firstDayOfWeek == 0)
            {
                firstDayOfWeek = sunday;
            }
            int day = 1;
            int week = 0;
            int weekDay = firstDayOfWeek - 1;
            for (int i = firstDayOfWeek; i < daysInMonth + firstDayOfWeek; i++)
            {
                TextBlock dayNumber = new TextBlock();
                dayNumber.Text = day.ToString();
                dayNumber.SetValue(Grid.RowProperty, week);
                dayNumber.SetValue(Grid.ColumnProperty, weekDay);
                MonthView.Children.Add(dayNumber);
                if (weekDay == sunday)
                {
                    week++;
                    weekDay = 0;
                }
                else
                {
                    weekDay++;
                }
                day++;
            }
        }

        private void SetTitle()
        {
            string title = CalendarDate.ToString("MMMM") + " " + CalendarDate.Year;
            Title.Text = title;
        }
    }
}
