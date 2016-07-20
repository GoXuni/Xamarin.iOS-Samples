// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using System.Collections.Generic;

namespace FlexPieSample
{
	public partial class LegendAndTitlesController : UIViewController
	{
		public LegendAndTitlesController (IntPtr handle) : base (handle)
		{
			
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			legendModeSelector.SelectedSegment = 3;
			IEnumerable<PieChartData> pieData = PieChartData.DemoData ();

			flexPie.Binding = "Value";
			flexPie.BindingName = "Name";
			flexPie.ItemsSource = pieData;
			flexPie.Tooltip.IsVisible = true;
			flexPie.Legend.Position = Xuni.iOS.ChartCore.Position.Right;
			flexPie.Header = headerField.Text;
			flexPie.Footer = footerField.Text;

		}

		partial void changeLegendMode (UISegmentedControl sender)
		{
			flexPie.Legend.Position = (Xuni.iOS.ChartCore.Position)(int)sender.SelectedSegment;
		}

		partial void edited (UITextField sender)
		{
			flexPie.Header = headerField.Text;
			flexPie.Footer = footerField.Text;
		}

		partial void endEdit (UITextField sender)
		{
			sender.ResignFirstResponder();
		}
	}
}
