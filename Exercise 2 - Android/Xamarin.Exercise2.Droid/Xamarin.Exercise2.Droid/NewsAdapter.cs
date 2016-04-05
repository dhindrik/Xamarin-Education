using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Xamarin.Exercise2.Droid
{
    public class NewsAdapter : BaseAdapter
    {
        public Activity _activity;

        private List<Tuple<string, string>> _items;

        public NewsAdapter(Activity activity)
        {
            _activity = activity;

            _items = new List<Tuple<string, string>>();

            _items.Add(new Tuple<string, string>("Microsoft köper Xamarin", "Nu är det klart att Microsoft köper det San Francisco baserade företaget Xamarin"));
            _items.Add(new Tuple<string, string>("Sogeti i topp", "Sogeti är än en gång i topp!"));

            _items.Add(new Tuple<string, string>("Microsoft köper Xamarin", "Nu är det klart att Microsoft köper det San Francisco baserade företaget Xamarin"));
            _items.Add(new Tuple<string, string>("Sogeti i topp", "Sogeti är än en gång i topp!"));
        }

        public override int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return 0;
        }

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = _activity.LayoutInflater.Inflate(Resource.Layout.newsitem,null);

            var header = view.FindViewById<TextView>(Resource.Id.header);
            var text = view.FindViewById<TextView>(Resource.Id.text);

            var item = _items[position];

            header.Text = item.Item1;
            text.Text = item.Item2;

            return view;
        }
    }
}