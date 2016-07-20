// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace FlexChartSample
{
	public partial class ThemingController : UIViewController
	{
		public ThemingController (IntPtr handle) : base (handle)
		{
		}

		public class ThemeModel : UIPickerViewModel
		{
			ThemingController tk = null;

			public ThemeModel(ThemingController tk)
			{
				this.tk = tk;
			}

			public override nint GetComponentCount(UIPickerView v)
			{
				return 1;
			}

			public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
			{
				return tk.pickerData.Length;
			}

			public override string GetTitle(UIPickerView picker, nint row, nint component)
			{
				if (component == 0)
					return tk.pickerData[row];
				else
					return row.ToString();
			}

			public override void Selected(UIPickerView picker, nint row, nint component)
			{
				nint selected = picker.SelectedRowInComponent(0);
				var chart = tk.chart;
				switch (selected)
				{
					case 0:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Standard;
						break;
					case 1:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Cocoa;
						break;
					case 2:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Coral;
						break;
					case 3:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Dark;
						break;
					case 4:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Highcontrast;
						break;
					case 5:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Light;
						break;
					case 6:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Midnight;
						break;
					case 7:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Minimal;
						break;
					case 8:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Modern;
						break;
					case 9:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Organic;
						break;
					case 10:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Slate;
						break;
					case 11:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Zen;
						break;
					case 12:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Cyborg;
						break;
					case 13:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Superhero;
						break;
					case 14:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Flatly;
						break;
					case 15:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Darkly;
						break;
					case 16:
						chart.Palette = Xuni.iOS.ChartCore.XuniPalettes.Cerulean;
						break;
					default:
						break;
				}

			}
		}


		string[] pickerData = new string[] { "Standard", "Cocoa", "Coral", "Dark", "HighContrast", "Light", "Midnight", "Minimal", "Modern", "Organic", "Slate", "Zen", "Cyborg", "Superhero", "Flatly", "Darkly", "Cerulean" };


		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			picker.Model = new ThemeModel(this);
			picker.ShowSelectionIndicator = true;
			picker.Hidden = false;

			this.chart.BindingX = "Name";
			this.chart.Series.Add(new Xuni.iOS.FlexChart.Series(this.chart, "Sales, Sales", "Sales"));
			this.chart.Series.Add(new Xuni.iOS.FlexChart.Series(this.chart, "Expenses, Expenses", "Expenses"));
			this.chart.Series.Add(new Xuni.iOS.FlexChart.Series(this.chart, "Downloads, Downloads", "Downloads"));
			this.chart.ItemsSource = SalesData.GetSalesDataList();

		}
	}
}
