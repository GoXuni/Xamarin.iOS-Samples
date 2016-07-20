// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using Xuni.iOS.Core;
using Xuni.iOS.ChartCore;
using Xuni.iOS.FlexChart;
using CoreGraphics;

namespace FlexChartSample
{
	public partial class CustomTooltipsController : UIViewController
	{
		public class MyTooltip : XuniBaseChartTooltipView
		{
			float tooltipHeight = 0, tooltipWidth = 0;
			UILabel label;
			UIImage image;
			UIImageView imageView;

			public override XuniDataPoint ChartData
			{
				get
				{
					return base.ChartData;
				}
				set
				{
					base.ChartData = value;
					XuniChartDataPoint cdpt = (XuniChartDataPoint)value;
					var countryNum = cdpt.PointIndex;

					if (label == null && imageView == null)
					{
						label = new UILabel(new CGRect(this.Bounds.Size.Width / 4, 0, this.Bounds.Size.Width * 3 / 4, this.Bounds.Size.Height));
						label.TextColor = UIColor.Black;
						label.Lines = 3;
						label.Text = string.Format("{0} \n\n {1:C2}", cdpt.SeriesName, cdpt.Value);
						label.Font = label.Font.WithSize(11);

						image = new UIImage("Images/" + SalesData.GetCountries()[countryNum]);
						imageView = new UIImageView(image);
						this.AddSubview(imageView);
						this.AddSubview(label);
					}
					else {
						image = new UIImage("Images/" + SalesData.GetCountries()[countryNum]);
						imageView.Image = image;
						label.Text = string.Format("{0} \n\n {1:C2}", cdpt.SeriesName, cdpt.Value);
						imageView.SetNeedsLayout();
						label.SetNeedsLayout();
					}
				}
			}

			public override void Render()
			{
				//Empty to prevent base tooltip drawing
			}

			public override CGRect GetFrameRect(CGRect contentFrame, CGPoint senderPoint)
			{
				tooltipHeight = 50;
				tooltipWidth = 100;
				if ((UIScreen.MainScreen.Bounds.Size.Width - senderPoint.X) < tooltipWidth && (UIScreen.MainScreen.Bounds.Size.Height - SenderPoint.Y) < tooltipHeight)
				{

					return new CGRect((UIScreen.MainScreen.Bounds.Size.Width - tooltipWidth), (UIScreen.MainScreen.Bounds.Size.Height - tooltipHeight), tooltipWidth, tooltipHeight);
				}
				else if ((UIScreen.MainScreen.Bounds.Size.Width - senderPoint.X) < tooltipWidth)
				{
					return new CGRect((UIScreen.MainScreen.Bounds.Size.Width - tooltipWidth), senderPoint.Y, tooltipWidth, tooltipHeight);
				}
				else if ((UIScreen.MainScreen.Bounds.Size.Height - senderPoint.Y) < tooltipHeight)
				{
					return new CGRect(senderPoint.X, (UIScreen.MainScreen.Bounds.Size.Height - tooltipHeight), tooltipWidth, tooltipHeight);
				}
				else {
					return new CGRect(senderPoint.X, senderPoint.Y, tooltipWidth, tooltipHeight);
				}

			}

			public override CGRect GetContentFrameRect(CGRect contentFrame, CGPoint senderPoint)
			{
				tooltipHeight = 50;
				tooltipWidth = 100;
				if ((UIScreen.MainScreen.Bounds.Size.Width - senderPoint.X) < tooltipWidth && (UIScreen.MainScreen.Bounds.Size.Height - senderPoint.Y) < tooltipHeight)
				{
					return new CGRect((UIScreen.MainScreen.Bounds.Size.Width - tooltipWidth), (UIScreen.MainScreen.Bounds.Size.Height - tooltipHeight), tooltipWidth, tooltipHeight);
				}
				else if ((UIScreen.MainScreen.Bounds.Size.Width - senderPoint.X) < tooltipWidth)
				{
					return new CGRect((UIScreen.MainScreen.Bounds.Size.Width - tooltipWidth), senderPoint.Y, tooltipWidth, tooltipHeight);
				}
				else if ((UIScreen.MainScreen.Bounds.Size.Height - senderPoint.Y) < tooltipHeight)
				{
					return new CGRect(senderPoint.X, (UIScreen.MainScreen.Bounds.Size.Height - tooltipHeight), tooltipWidth, tooltipHeight);
				}
				else {
					return new CGRect(senderPoint.X, senderPoint.Y, tooltipWidth, tooltipHeight);
				}

			}
		}

		public CustomTooltipsController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			chart.BindingX = "Name";
			chart.Series.Add(new Series(chart, "Sales, Sales", "Sales"));
			chart.Series.Add(new Series(chart, "Expenses, Expenses", "Expenses"));
			chart.Series.Add(new Series(chart, "Downloads, Downloads", "Downloads"));

			chart.Stacking = Stacking.Stacked;
			chart.Palette = XuniPalettes.Zen;
			chart.LoadAnimation.AnimationMode = AnimationMode.Series;
			chart.AxisY.AxisLineVisible = false;
			chart.AxisY.MajorUnit = 2000;

			var tooltip = new MyTooltip();
			tooltip.BackgroundColor = new UIColor(1.0f, 1.0f, 0.792f, 1.0f);
			chart.Tooltip.Content = tooltip;

			chart.ItemsSource = SalesData.GetSalesDataList();
		}
	}
}