using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Xamarin.Exercise1.iOS
{
	partial class NewsTableController : UITableViewController
	{
		public NewsTableController (IntPtr handle) : base (handle)
		{
            
		}

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            return base.GetCell(tableView, indexPath);
        }
    }
}
