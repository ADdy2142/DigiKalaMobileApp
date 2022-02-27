using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigiKalaMobileApp.ViewModels
{
    public class AddressesViewModel
    {
        public Command BackCommand { get; set; }

        public AddressesViewModel()
        {
            BackCommand = new Command(GoToPreviousPage);
        }

        private async void GoToPreviousPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}