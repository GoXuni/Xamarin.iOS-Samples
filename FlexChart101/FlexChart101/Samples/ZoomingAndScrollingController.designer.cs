// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FlexChartSample
{
	[Register ("ZoomingAndScrollingController")]
	partial class ZoomingAndScrollingController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexChart.FlexChart chart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl zoomModeSelector { get; set; }

		[Action ("zoomModeChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void zoomModeChanged (UISegmentedControl sender);

		void ReleaseDesignerOutlets ()
		{
			if (chart != null) {
				chart.Dispose ();
				chart = null;
			}
			if (zoomModeSelector != null) {
				zoomModeSelector.Dispose ();
				zoomModeSelector = null;
			}
		}
	}
}
