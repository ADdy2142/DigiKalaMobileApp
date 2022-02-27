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
    public class ProductDetailsViewModel : ViewModelBase
    {
        public Command OpenSearchPageCommand { get; set; }
        public Command BackCommand { get; set; }

        private ObservableCollection<ProductImage> _productImages;

        public ObservableCollection<ProductImage> ProductImages
        {
            get => _productImages;
            set
            {
                _productImages = value;
                OnPropertyChanged(nameof(ProductImages));
            }
        }

        private ProductColor _selectedProductColor;

        public ProductColor SelectedProductColor
        {
            get => _selectedProductColor;
            set
            {
                _selectedProductColor = value;
                OnPropertyChanged(nameof(SelectedProductColor));
            }
        }

        private ObservableCollection<ProductColor> _productColors;

        public ObservableCollection<ProductColor> ProductColors
        {
            get => _productColors;
            set
            {
                _productColors = value;
                OnPropertyChanged(nameof(ProductColors));
            }
        }

        private ObservableCollection<Product> _similarProducts;

        public ObservableCollection<Product> SimilarProducts
        {
            get => _similarProducts;
            set
            {
                _similarProducts = value;
                OnPropertyChanged(nameof(SimilarProducts));
            }
        }

        private ObservableCollection<Comment> _comments;

        public ObservableCollection<Comment> Comments
        {
            get => _comments;
            set
            {
                _comments = value;
                OnPropertyChanged(nameof(Comments));
            }
        }

        public ProductDetailsViewModel()
        {
            OpenSearchPageCommand = new Command(OpenSearchPage);
            BackCommand = new Command(BackToPreviousPage);
            ProductImages = new ObservableCollection<ProductImage>();
            SelectedProductColor = null;
            ProductColors = new ObservableCollection<ProductColor>();
            SimilarProducts = new ObservableCollection<Product>();
            Comments = new ObservableCollection<Comment>();

            GetProductImages();
            GetProductColors();
            GetSimilarProducts();
            GetComments();
        }

        private async void OpenSearchPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SearchPage());
        }

        private async void BackToPreviousPage(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        private void GetProductImages()
        {
            ProductImages = new ObservableCollection<ProductImage>(UnitOfWork.ProductImages.GetAll());
        }

        private void GetProductColors()
        {
            ProductColors = new ObservableCollection<ProductColor>(UnitOfWork.ProductColors.GetAll());
            SelectedProductColor = ProductColors.FirstOrDefault();
        }

        private void GetSimilarProducts()
        {
            SimilarProducts = new ObservableCollection<Product>(UnitOfWork.Products.GetSimilarProducts());
        }

        private void GetComments()
        {
            Comments = new ObservableCollection<Comment>(UnitOfWork.Comments.GetAll());
        }
    }
}