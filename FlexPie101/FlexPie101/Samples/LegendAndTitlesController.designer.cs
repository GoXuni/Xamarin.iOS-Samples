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

namespace FlexPieSample
{
	[Register ("LegendAndTitlesController")]
	partial class LegendAndTitlesController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		Xuni.iOS.FlexPie.FlexPie flexPie { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField footerField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField headerField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISegmentedControl legendModeSelector { get; set; }

		[Action ("changeLegendMode:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void changeLegendMode (UISegmentedControl sender);

		[Action ("edited:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void edited (UITextField sender);

		[Action ("endEdit:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void endEdit (UITextField sender);

		void ReleaseDesignerOutlets ()
		{
			if (flexPie != null) {
				flexPie.Dispose ();
				flexPie = null;
			}
			if (footerField != null) {
				footerField.Dispose ();
				footerField = null;
			}
			if (headerField != null) {
				headerField.Dispose ();
				headerField = null;
			}
			if (legendModeSelector != null) {
				legendModeSelector.Dispose ();
				legendModeSelector = null;
			}
		}
	}
}
