using DigiKalaMobileApp.Models;
using DigiKalaMobileApp.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigiKalaMobileApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Command OpenSearchPageCommand { get; set; }

        private Models.MenuItem _selectedMenuItem;

        public Models.MenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                _selectedMenuItem = value;
                OnPropertyChanged(nameof(SelectedMenuItem));
            }
        }

        private ObservableCollection<Models.MenuItem> _menuItems;

        public ObservableCollection<Models.MenuItem> MenuItems
        {
            get => _menuItems;
            set
            {
                _menuItems = value;
                OnPropertyChanged(nameof(MenuItems));
            }
        }

        private bool _showLoading;

        public bool ShowLoading
        {
            get => _showLoading;
            set
            {
                _showLoading = value;
                OnPropertyChanged(nameof(ShowLoading));
            }
        }

        public MainViewModel()
        {
            OpenSearchPageCommand = new Command(OpenSearchPage);
            SelectedMenuItem = null;
            MenuItems = new ObservableCollection<Models.MenuItem>();
            ShowLoading = false;

            GetMenuItems();
            SelectedMenuItem = MenuItems[MenuItems.Count - 1];
        }

        private async void OpenSearchPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }

        private void GetMenuItems()
        {
            MenuItems = new ObservableCollection<Models.MenuItem>(UnitOfWork.MenuItems.GetAll());
        }
    }
}