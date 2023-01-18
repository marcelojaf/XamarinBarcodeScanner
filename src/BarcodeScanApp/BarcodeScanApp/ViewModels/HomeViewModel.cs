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

        public Command BtnMLKitCommand => new Command(async () =>
        {
            bool allowed = false;
            allowed = await BarcodeScanner.Mobile.XamarinForms.Methods.AskForRequiredPermission();
            if (allowed)
                await Navigation.PushModalAsync(new NavigationPage(new MLKitPage()));
        });
    }
}

