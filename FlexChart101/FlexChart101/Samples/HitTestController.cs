// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexChart;
using System.Linq;
using System.Collections.Generic;

namespace FlexChartSample
{
	public partial class HitTestController : UIViewController
	{
		public HitTestController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			int len = 40;
			List<XuniPoint> listCosTuple = new List<XuniPoint>();
			List<XuniPoint> listSinTuple = new List<XuniPoint>();

			for (int i = 0; i < len; i++)
			{
				listCosTuple.Add(new XuniPoint(i, Math.Cos(0.12 * i)));
				listSinTuple.Add(new XuniPoint(i, Math.Sin(0.12 * i)));
			}

			chart.BindingX = "X"; 
			chart.Series.Add(new Series(chart, "Y, Y", "cos(x)") { ItemsSource = listCosTuple });
			chart.Series.Add(new Series(chart, "Y, Y", "sin(x)") { ItemsSource = listSinTuple });

			chart.ChartType = ChartType.LineSymbols;
			chart.AxisY.Format = "F";
			chart.Header = "Trigonometric Functions";
			chart.Footer = "Cartesian coordinates";

			chart.Tapped += (sender, point) =>
			{
				XuniChartHitTestInfo ht = ((FlexChart)sender).HitTest(point);

				pointIndexLabel.Text = string.Format(" Point Index: {0}", ht.DataPoint.PointIndex);
				xyValuesLabel.Text = string.Format(" X: {0}, Y: {1:F2}", ht.DataPoint.ValueX, ht.DataPoint.Value);

				if (ht.DataPoint.SeriesIndex >= 0 && ht.DataPoint.SeriesIndex < chart.Series.Count)
				{
					seriesLabel.Text = string.Format(" Series: {0}", ht.DataPoint.SeriesName);
				}
				else
				{
					seriesLabel.Text = " Series: ";
				}
				chartElementLabel.Text = string.Format(" Chart element: {0}", ht.ChartElement.ToString());
				return false;
			};
		}


	}
}
