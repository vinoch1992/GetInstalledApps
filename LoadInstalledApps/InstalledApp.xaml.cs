using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LoadInstalledApps
{
    public partial class InstalledApp : ContentPage
    {
        public InstalledApp()
        {
            InitializeComponent();

            BindingContext = new InstalledAppViewModel();
        }
    }
}
