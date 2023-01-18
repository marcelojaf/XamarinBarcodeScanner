using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BarcodeScanApp.Views
{
    public partial class ZXingPage : ContentPage
    {
        public ZXingPage()
        {
            InitializeComponent();

            btnScan.Clicked += async (sender, e) =>
            {

#if __ANDROID__
	// Initialize the scanner first so it can track the current context
	MobileBarcodeScanner.Initialize (Application);
#endif

                var scanner = new ZXing.Mobile.MobileBarcodeScanner();

                var result = await scanner.Scan();

                if (result != null)
                {
                    txtScannedContent.Text = result.Text;
                }
            };
        }
    }
}

