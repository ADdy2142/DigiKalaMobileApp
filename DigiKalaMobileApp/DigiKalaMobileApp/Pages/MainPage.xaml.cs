using DigiKalaMobileApp.Pages.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigiKalaMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        private string _currentContentTitle = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CvMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMenuItem = CvMenu.SelectedItem as Models.MenuItem;
            if (_currentContentTitle.Equals(selectedMenuItem.Title))
                return;

            _currentContentTitle = selectedMenuItem.Title;
            GrdMainContent.Children.Clear();
            ViewModel.ShowLoading = true;
            await ChangeTabContentAsync();
        }

        private async Task ChangeTabContentAsync()
        {
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(2000);
                ViewModel.ShowLoading = false;

                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    var title = ViewModel.SelectedMenuItem.Title;
                    View newContent;
                    switch (title)
                    {
                        case "خانه":
                            newContent = new HomeView();
                            GrdMainContent.Children.Add(newContent);
                            break;

                        case "دسته بندی ها":
                            newContent = new CategoriesView();
                            GrdMainContent.Children.Add(newContent);
                            break;

                        case "سبد خرید":
                            newContent = new ShoppingCartView();
                            GrdMainContent.Children.Add(newContent);
                            break;

                        case "پروفایل":
                            newContent = new ProfileView();
                            GrdMainContent.Children.Add(newContent);
                            break;
                    }
                });
            });
        }
    }
}