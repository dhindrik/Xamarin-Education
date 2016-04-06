using Exercise3.XF.Models;
using Exercise3.XF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercise3.XF.ViewModels
{
    public class NewsViewModel : ViewModel
    {
        public ObservableCollection<NewsItem> Items { get; set; }

        public NewsViewModel(INavigation navigation) : base(navigation)
        {
            Items = new ObservableCollection<NewsItem>();
            Items.Add(new NewsItem() { Header = "Leksand till SHL", Text = "Leksand spelar i SHL 16/17! :)" });
            Items.Add(new NewsItem() { Header = "Microsoft köper Xamarin", Text = "Xamarin är nu gratis för alla!!" });
            Items.Add(new NewsItem() { Header = "Sogeti + Xamarin", Text = "Sogeti utbildar nya Xamarinutvecklare!" });
        }

        public NewsItem SelectedItem
        {
            set
            {
                if (value!=null)
                {
                    Navigation.PushAsync(new DetailsView()); 
                }
            }
        }
    }
}
