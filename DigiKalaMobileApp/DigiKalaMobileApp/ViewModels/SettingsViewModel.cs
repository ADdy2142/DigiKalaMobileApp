using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigiKalaMobileApp.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public Command BackCommand { get; set; }

        private bool _isNotificationEnable;

        public bool IsNotificationEnable
        {
            get => _isNotificationEnable;
            set
            {
                _isNotificationEnable = value;
                OnPropertyChanged(nameof(IsNotificationEnable));
            }
        }

        private bool _isNewsletterMembershipEnable;

        public bool IsNewsletterMembershipEnable
        {
            get => _isNewsletterMembershipEnable;
            set
            {
                _isNewsletterMembershipEnable = value;
                OnPropertyChanged(nameof(IsNewsletterMembershipEnable));
            }
        }

        public SettingsViewModel()
        {
            BackCommand = new Command(BackToPreviousPage);
            IsNotificationEnable = true;
            IsNewsletterMembershipEnable = false;
        }

        private async void BackToPreviousPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}