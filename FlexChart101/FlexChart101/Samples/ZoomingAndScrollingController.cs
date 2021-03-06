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
	public partial class ZoomingAndScrollingController : UIViewController
	{
		public ZoomingAndScrollingController (IntPtr handle) : base (handle)
		{
		}

		partial void zoomModeChanged(UISegmentedControl sender)
		{
			chart.ZoomMode = (ZoomMode)(int)sender.SelectedSegment;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			chart.ItemsSource = GenerateRandNormal(500);
			chart.Palette = XuniPalettes.Superhero;
			chart.Header = "Drag to scroll / pinch to zoom";
			chart.AxisY.Format = "n2";

			chart.BindingX = "X";

			chart.Series.Add(new Series(chart, "Y", "Normal Distribution"));

			chart.ChartType = ChartType.Scatter;
			chart.ZoomMode = ZoomMode.XY;

			zoomModeSelector.SelectedSegment = 2;
		}

		Random rnd = new Random();

		List<XuniPoint> GenerateRandNormal(int n)
		{
			if (n % 2 == 1)
				n++;

			List<XuniPoint> points = new List<XuniPoint>(n);

			for (int i = 0; i < n / 2; i++)
			{
				do
				{
					double u = 2 * rnd.NextDouble() - 1;
					double v = 2 * rnd.NextDouble() - 1;

					double s = u * u + v * v;

					if (s < 1)
					{
						s = Math.Sqrt(-2 * Math.Log(s) / s);
						points.Add(new XuniPoint(i, u * s));
						points.Add(new XuniPoint(i + 1, v * s));
						break;
					}
				} while (true);
			}

			return points;
		} 
	}
}
