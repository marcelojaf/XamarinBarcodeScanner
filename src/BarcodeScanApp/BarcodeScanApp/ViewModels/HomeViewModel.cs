using System;
using BarcodeScanApp.Views;
using Xamarin.Forms;

namespace BarcodeScanApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
        }

        public Command BtnZXingCommand => new Command(async () =>
        {
            await Navigation.PushAsync(new ZXingPage());
        });
     }
}

