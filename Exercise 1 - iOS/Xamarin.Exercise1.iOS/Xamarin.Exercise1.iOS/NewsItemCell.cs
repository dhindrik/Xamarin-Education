using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Xamarin.Exercise1.iOS
{
	partial class NewsItemCell : UITableViewCell
	{
		public NewsItemCell (IntPtr handle) : base (handle)
		{
		}

        public void SetValues(string header, string text)
        {
            Header.Text = header;
            Text.Text = text;
        }
	}
}
