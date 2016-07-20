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
	public partial class ConditionalFormattingController : UIViewController
	{
		public ConditionalFormattingController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			List<XuniPoint> listPoints = new List<XuniPoint>();
			for (int i = 0; i < 30; i++)
			{
				listPoints.Add(new XuniPoint(0.16 * i, Math.Cos(0.12 * i)));
			}

			chart.BindingX = "X";
			chart.Series.Add(new Series(chart, "Y", "Sine"));
			chart.ChartType = ChartType.LineSymbols;

			chart.AxisY.Format = "F1";
			chart.AxisX.Format = "F1";

			chart.ItemsSource = listPoints;

			chart.LoadAnimation.AnimationMode = AnimationMode.Point;

			chart.IsHandleXFPlotElementLoading = true;

			chart.HandlePlotElementLoading += delegate (FlexChart sender, XuniRenderEngine renderEngine, XuniRect rect, int pointIndex, XuniPoint point, int seriesIndex, BasePlotElementRender defaultRender)
			{
				float y = (float)listPoints[pointIndex].Y;

				float r = (y >= 0 ? 1 : ((1 + y)));
				float b = (y < 0 ? 1 : ((1 - y)));
				float g = (1 - Math.Abs(y));
				float a = 0.8f;

				renderEngine.SetFillColor(new UIColor(r, g, b, a));

				return false;
			};
		}


	}
}
