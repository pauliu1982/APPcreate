using Xamarin.Forms;

namespace App1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem1_Clicked(object sender, System.EventArgs e)
        {
            Xamarin.Essentials.Browser.OpenAsync("https://jamestsai.tw", 
                                                  Xamarin.Essentials.BrowserLaunchMode.External);
        }

        private void MenuItem2_Clicked(object sender, System.EventArgs e)
        {
            Xamarin.Essentials.PhoneDialer.Open("1122");
        }
    }
}
