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

namespace Xamarin.Exercise1.iOS
{
	[Register ("NewsItemCell")]
	partial class NewsItemCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Header { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Text { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Header != null) {
				Header.Dispose ();
				Header = null;
			}
			if (Text != null) {
				Text.Dispose ();
				Text = null;
			}
		}
	}
}
