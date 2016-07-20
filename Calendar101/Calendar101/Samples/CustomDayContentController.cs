// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using Xuni.iOS.Core;
using Xuni.iOS.Calendar;
using CoreGraphics;

namespace CalendarSample
{
	public partial class CustomDayContentController : UIViewController
	{
		public CustomDayContentController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			calendar.DayOfWeekFormat = Xuni.iOS.Calendar.XuniDayOfWeekFormat.DDDD;
			calendar.CalendarFont = UIFont.BoldSystemFontOfSize (14);
			calendar.TodayFont = UIFont.BoldSystemFontOfSize (14);

			string[] weatherIcon =  new string[]{"Images/Sunny-icon", "Images/Overcast-icon", "Images/rain-icon", "Images/thunder-lightning-storm-icon"};
			string[] dotIcon = new string[]{"Images/blue", "Images/red", "Images/green"};

			calendar.DaySlotLoading += (sender, date, isAdjacentDay, daySlot) => {
				if (isAdjacentDay) {
					return daySlot;
				}

				nint day = NSCalendar.CurrentCalendar.Components(NSCalendarUnit.Day, date).Day;

				CGRect rect = daySlot.Frame;
				CGSize size = rect.Size;
				CGRect rect1, rect2;

				CalendarImageDaySlot imageDaySlot = new CalendarImageDaySlot((Xuni.iOS.Calendar.XuniCalendar)sender, rect);

				if (day >= 14 && day <= 23) {
					rect1 = new CGRect(0, 0, size.Height / 4, size.Height / 4);
					rect2 = new CGRect(size.Width / 4, size.Height / 5 * 2, size.Width / 2, size.Height / 2);

					imageDaySlot.DayTextRect = rect1;
					imageDaySlot.DayFont = UIFont.SystemFontOfSize(9);
					imageDaySlot.ImageRect = rect2;
					imageDaySlot.ImageSource = new UIImage(weatherIcon[day%4]);
				}
				else {
					rect1 = new CGRect(0, 0, size.Width, size.Height / 6 * 4);
					rect2 = new CGRect(size.Width / 2 - 6 / 2, size.Height / 6 * 4, 6, 6);

					imageDaySlot.DayTextRect = rect1;
					imageDaySlot.ImageRect = rect2;
					imageDaySlot.ImageSource = new UIImage(dotIcon[day%3]);
				}

				return imageDaySlot;
			};

			calendar.DayOfWeekSlotLoading += (object sender, Xuni.iOS.Calendar.DayOfWeekSlotLoadingEventArgs e) => {
				e.DayOfWeekSlot.Font = e.IsWeekend?UIFont.ItalicSystemFontOfSize(11):UIFont.BoldSystemFontOfSize(11);
			};
		}
	}
}
