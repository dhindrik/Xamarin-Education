using Exercise3.XF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Exercise3.XF.Views
{
    public partial class NewsView : ContentPage
    {
        public NewsView()
        {
            InitializeComponent();

            BindingContext = new NewsViewModel(Navigation);
        }
    }
}
