using DigiKalaMobileApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigiKalaMobileApp.ViewModels
{
    public class ProfileViewModel : ViewModelBase
    {
        public Command OpenSettingsPageCommand { get; set; }
        public Command OpenListsPageCommand { get; set; }
        public Command OpenAddressesPageCommand { get; set; }

        public ProfileViewModel()
        {
            OpenSettingsPageCommand = new Command(OpenSettingsPage);
            OpenListsPageCommand = new Command(OpenListsPage);
            OpenAddressesPageCommand = new Command(OpenAddressesPage);
        }

        private async void OpenSettingsPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SettingsPage());
        }

        private async void OpenListsPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListsPage());
        }

        private async void OpenAddressesPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AddressesPage());
        }
    }
}