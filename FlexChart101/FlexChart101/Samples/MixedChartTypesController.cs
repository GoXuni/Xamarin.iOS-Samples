// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace FlexChartSample
{
	public partial class MixedChartTypesController : UIViewController
	{
		public MixedChartTypesController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			chart.BindingX = "Name";

			chart.Series.Add(new Xuni.iOS.FlexChart.Series(chart, "Sales, Sales", "Sales"));
			chart.Series.Add(new Xuni.iOS.FlexChart.Series(chart, "Expenses, Expenses", "Expenses"));
			chart.Series.Add(new Xuni.iOS.FlexChart.Series(chart, "Downloads, Downloads", "Downloads") { ChartType = Xuni.iOS.FlexChart.ChartType.Line});

			chart.ItemsSource = SalesData.GetSalesDataList();
		}
	}
}
