// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace CalendarSample
{
	public partial class CustomHeaderController : UIViewController
	{
		public CustomHeaderController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			calendar.ShowHeader = false;

			calendar.ViewModeChanged += (object sender, EventArgs e) => 
			{
				if (calendar.ViewMode == Xuni.iOS.Calendar.XuniCalendarViewMode.Month) {
					modeSelector.SelectedSegment = 0;
				}
				else if (calendar.ViewMode == Xuni.iOS.Calendar.XuniCalendarViewMode.Year) {
					modeSelector.SelectedSegment = 1;
				}

				this.UpdateDataLabel();
			};

			calendar.DisplayDateChanged += (object sender, EventArgs e) => 
			{
				UpdateDataLabel ();
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			UpdateDataLabel ();
		}

		public void UpdateDataLabel()
		{
			dateLabel.Text = calendar.DisplayDate.ToString ("y");
		}

		partial void selectMode (UISegmentedControl sender)
		{
			if (modeSelector.SelectedSegment == 0) {
				calendar.ChangeViewModeAsync(Xuni.iOS.Calendar.XuniCalendarViewMode.Month, null);
			}
			else if (modeSelector.SelectedSegment == 1) {
				calendar.ChangeViewModeAsync(Xuni.iOS.Calendar.XuniCalendarViewMode.Year, null);
			}
		}

		partial void selectToday (UIBarButtonItem sender)
		{
			calendar.SelectedDate = DateTime.Now;
			calendar.DisplayDate = DateTime.Now;
		}
	}
}
