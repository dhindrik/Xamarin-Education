using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercise3.XF.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation { get; private set; }

        public ViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
