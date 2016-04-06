using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Exercise3.XF.ViewModels
{
    public class LoginViewModel : ViewModel
    {
        public LoginViewModel(INavigation navigation) : base(navigation) { }

        private string _username;
        public string Username
        {
            get { return _username; }
            set { _username = value; RaisePropertyChanged(); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; RaisePropertyChanged(); }
        }
        private bool _isLoggedIn;
        public bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; RaisePropertyChanged(); RaisePropertyChanged("IsNotLoggedIn"); }
        }
        public bool IsNotLoggedIn { get { return !IsLoggedIn; } }

        public ICommand Login
        {
            get
            {
                return new Command(() =>
          {
              IsLoggedIn = true;
          });
            }
        }
    }
}
