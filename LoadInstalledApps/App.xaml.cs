using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoadInstalledApps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InstalledApp();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
