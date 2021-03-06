// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace CalendarSample
{
	public partial class CustomSelectionController : UIViewController
	{
		public CustomSelectionController (IntPtr handle) : base (handle)
		{
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			calendar.MaxSelectionCount = 100;
			calendar.SelectionChanging += (object sender, Xuni.iOS.Calendar.SelectionChangingEventArgs e) => {
				NSDateComponents components = new NSDateComponents();
				components.Day = 1;

				for(NSDate date = e.SelectedDates.StartDate;
					date.Compare(e.SelectedDates.EndDate) == NSComparisonResult.Ascending || 
					date.Compare(e.SelectedDates.EndDate) == NSComparisonResult.Same;
					date = NSCalendar.CurrentCalendar.DateByAddingComponents(components, date, NSCalendarOptions.None))
				{
					nint weekday = NSCalendar.CurrentCalendar.Components(NSCalendarUnit.Weekday, date).Weekday;

					if (weekday == 1 || weekday == 7) {
						e.SelectedDates.AddExcludedDates(date);
					}
				}
			};
		}
	}
}
