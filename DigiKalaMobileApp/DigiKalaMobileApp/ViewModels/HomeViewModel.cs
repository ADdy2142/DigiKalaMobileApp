using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ObservableCollection<Banner> _banners;

        public ObservableCollection<Banner> Banners
        {
            get => _banners;
            set
            {
                _banners = value;
                OnPropertyChanged(nameof(Banners));
            }
        }

        private ObservableCollection<Product> _topDiscountProducts;

        public ObservableCollection<Product> TopDiscountProducts
        {
            get => _topDiscountProducts;
            set
            {
                _topDiscountProducts = value;
                OnPropertyChanged(nameof(TopDiscountProducts));
            }
        }

        private ObservableCollection<MostVisitedProduct> _mostVisitedProducts;

        public ObservableCollection<MostVisitedProduct> MostVisitedProducts
        {
            get => _mostVisitedProducts;
            set
            {
                _mostVisitedProducts = value;
                OnPropertyChanged(nameof(MostVisitedProducts));
            }
        }

        private ObservableCollection<BrandAd> _brandAds;

        public ObservableCollection<BrandAd> BrandAds
        {
            get => _brandAds;
            set
            {
                _brandAds = value;
                OnPropertyChanged(nameof(BrandAds));
            }
        }

        public HomeViewModel()
        {
            Banners = new ObservableCollection<Banner>();
            TopDiscountProducts = new ObservableCollection<Product>();
            MostVisitedProducts = new ObservableCollection<MostVisitedProduct>();
            BrandAds = new ObservableCollection<BrandAd>();

            GetBanners();
            GetTopDiscountProducts();
            GetMostVisitedProducts();
            GetBrandAds();
        }

        private void GetBanners()
        {
            Banners = new ObservableCollection<Banner>(UnitOfWork.Banners.GetAll());
        }

        private void GetTopDiscountProducts()
        {
            TopDiscountProducts = new ObservableCollection<Product>(UnitOfWork.Products.GetProductsWithDiscount());
        }

        private void GetMostVisitedProducts()
        {
            MostVisitedProducts = new ObservableCollection<MostVisitedProduct>(UnitOfWork.Products.GetMostVisitedProducts());
        }

        private void GetBrandAds()
        {
            BrandAds = new ObservableCollection<BrandAd>(UnitOfWork.BrandAds.GetAll());
        }
    }
}