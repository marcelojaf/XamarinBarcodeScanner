using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BarcodeScanApp.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;

		public INavigation Navigation => App.Current.MainPage.Navigation;
    }
}

