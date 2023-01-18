using System;
using System.Collections.Generic;
using BarcodeScanner.Mobile.Core;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace BarcodeScanApp.Views
{
    public partial class MLKitPage : ContentPage
    {
        public MLKitPage()
        {
            InitializeComponent();
            BarcodeScanner.Mobile.Core.Methods.SetSupportBarcodeFormat(BarcodeFormats.Code39 | BarcodeFormats.QRCode | BarcodeFormats.Code128);
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void FlashlightButton_Clicked(object sender, EventArgs e)
        {
            Camera.TorchOn = !Camera.TorchOn;
        }

        private void SwitchCameraButton_Clicked(object sender, EventArgs e)
        {
            Camera.CameraFacing = Camera.CameraFacing == CameraFacing.Back
                                      ? CameraFacing.Front
                                      : CameraFacing.Back;
        }

        private void CameraView_OnDetected(object sender, OnDetectedEventArg e)
        {
            List<BarcodeResult> obj = e.BarcodeResults;

            string result = string.Empty;
            for (int i = 0; i < obj.Count; i++)
            {
                result += $"Type : {obj[i].BarcodeType}, Value : {obj[i].DisplayValue}{Environment.NewLine}";
            }
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Result", result, "OK");
                Camera.IsScanning = true;
            });

            //Canvas.InvalidateSurface();

        }
    }
}

