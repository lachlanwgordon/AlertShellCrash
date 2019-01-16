using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellAlertCrashRepro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void AlertOnPage_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                DisplayAlert("Alert on page", "If you can see this the bug is fixed. Thanks for your help", "Okay");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error alerting\n{ex}\n{ex.StackTrace}");
            }
        }

        void ActionSheetOnPage_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                DisplayActionSheet("actionsheet on page", "If you can see this the bug is fixed.", "Okay");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in action sheet\n{ex}\n{ex.StackTrace}");
            }
        }

        void AlertOnShell_Clicked(object sender, System.EventArgs e)
        {
            Shell.CurrentShell.DisplayAlert("Alert on shell", "This is a work around alert.", "Okay");
        }

        void ActionSheetOnShell_Clicked(object sender, System.EventArgs e)
        {
            Shell.CurrentShell.DisplayActionSheet("Action sheet on sheet", "If you can see this the bug is fixed.", "Okay");
        }
    }
}
