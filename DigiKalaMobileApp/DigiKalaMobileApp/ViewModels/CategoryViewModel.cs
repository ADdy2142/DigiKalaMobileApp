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
    public class CategoryViewModel : ViewModelBase
    {
        public Command BackCommand { get; set; }
        public Command OpenSearchPageCommand { get; set; }
        public Command OpenProductDetailsPageCommand { get; set; }

        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        private Product _selectedProduct;

        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public CategoryViewModel()
        {
            BackCommand = new Command(GoToPreviousPage);
            OpenSearchPageCommand = new Command(OpenSearchPage);
            OpenProductDetailsPageCommand = new Command(OpenProductDetailsPage);
            Products = new ObservableCollection<Product>();
            SelectedProduct = null;

            GetProductsByCategory();
        }

        private async void GoToPreviousPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private async void OpenSearchPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }

        private async void OpenProductDetailsPage(object obj)
        {
            if (SelectedProduct == null)
                return;

            await Application.Current.MainPage.Navigation.PushAsync(new ProductDetailsPage());
            SelectedProduct = null;
        }

        private void GetProductsByCategory()
        {
            Products = new ObservableCollection<Product>(UnitOfWork.Products.GetProductsByCategory());
        }
    }
}