using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
		public MainPage()
		{
			InitializeComponent();
			SfCalendar calendar = new SfCalendar();
			this.Content = calendar;
			List<DateTime> black_dates = new List<DateTime>();
			for (int i = 0; i < 5; i++)
			{
				DateTime date = new DateTime(2018, 4, 1 + i);
				black_dates.Add(date);
			}
			calendar.BlackoutDates = black_dates;
		}

        public class CalendarViewModel
        {
            public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();
            public CalendarViewModel()
            {
                CalendarInlineEvent event1 = new CalendarInlineEvent();
                event1.StartTime = new DateTime(2022, 5, 1, 5, 0, 0);
                event1.EndTime = new DateTime(2022, 5, 1, 7, 0, 0);
                event1.Subject = "Go to Meeting";
                event1.Color = Color.Fuchsia;

                CalendarInlineEvent event2 = new CalendarInlineEvent();
                event2.StartTime = new DateTime(2022, 5, 1, 10, 0, 0);
                event2.EndTime = new DateTime(2022, 5, 1, 12, 0, 0);
                event2.Subject = "Planning";
                event2.Color = Color.Green;

                CalendarInlineEvents.Add(event1);
                CalendarInlineEvents.Add(event2);
            }
        }
    }


}



