using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using UIKit;

namespace Xamarin.Exercise1.iOS
{
	partial class NewsTableController : UITableViewController
	{
        private List<Tuple<string, string>> _items;

		public NewsTableController (IntPtr handle) : base (handle)
		{
            _items = new List<Tuple<string, string>>();

            _items.Add(new Tuple<string, string>("Microsoft k�per Xamarin", "Nu �r det klart att Microsoft k�per det San Francisco baserade f�retaget Xamarin"));
            _items.Add(new Tuple<string, string>("Sogeti i topp", "Sogeti �r �n en g�ng i topp!"));

            //TableView.Source = new TableSour
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("NewsCell") as NewsItemCell;

            //Not necessary when using storyboard
            if (cell == null)
            {
                cell = new NewsItemCell(Handle);
            }


            cell.SetValues(_items[indexPath.Row].Item1, _items[indexPath.Row].Item2);

            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return _items.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var message = string.Format("You selected: {0}", _items[indexPath.Row].Item1);

            var dialog = new UIAlertView()
            {
                Title = "Hi",
                Message = message
            };

            dialog.AddButton("OK");
            dialog.Show();
        }
    }
}
