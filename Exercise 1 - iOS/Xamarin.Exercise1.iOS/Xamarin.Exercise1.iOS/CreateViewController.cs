using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Xamarin.Exercise1.iOS
{
	partial class CreateViewController : UIViewController
	{
		public CreateViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Save.TouchUpInside += Save_TouchUpInside;
        }

        public override void ViewDidUnload()
        {
            base.ViewDidUnload();

            Save.TouchUpInside -= Save_TouchUpInside;
        }

        private void Save_TouchUpInside(object sender, EventArgs e)
        {
            var message = string.Format("Hello {0} {1}", FirstName.Text, LastName.Text);

            var dialog = new UIAlertView()
            {
                Title = "Welcome",
                Message = message
            };

            dialog.AddButton("OK");
            dialog.Show();

            var viewController = Storyboard.InstantiateViewController("MainTabs");

            NavigationController.ShowViewController(viewController, this);
        }
    }
}
