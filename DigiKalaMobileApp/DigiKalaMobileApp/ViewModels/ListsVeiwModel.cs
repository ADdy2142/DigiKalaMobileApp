using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigiKalaMobileApp.ViewModels
{
    public class ListsVeiwModel : ViewModelBase
    {
        public Command BackCommand { get; set; }

        public ListsVeiwModel()
        {
            BackCommand = new Command(BackToPreviousPage);
        }

        private async void BackToPreviousPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}