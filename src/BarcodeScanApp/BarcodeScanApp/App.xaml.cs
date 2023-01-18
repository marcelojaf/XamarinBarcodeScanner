using System;
using Xamarin.Forms;
using BarcodeScanApp.Views;
using Xamarin.Forms.Xaml;

namespace BarcodeScanApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

