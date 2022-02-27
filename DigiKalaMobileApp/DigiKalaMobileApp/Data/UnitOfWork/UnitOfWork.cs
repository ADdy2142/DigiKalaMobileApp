using DigiKalaMobileApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.UnitOfWork
{
    public class UnitOfWork
    {
        private SearchMatchRepository _searchMatchCaseRepository;

        public SearchMatchRepository SearchMatchCases
        {
            get
            {
                if (_searchMatchCaseRepository == null)
                    _searchMatchCaseRepository = new SearchMatchRepository();

                return _searchMatchCaseRepository;
            }
        }

        private BannerRepository _bannerRepository;

        public BannerRepository Banners
        {
            get
            {
                if (_bannerRepository == null)
                    _bannerRepository = new BannerRepository();

                return _bannerRepository;
            }
        }

        private ProductRepository _productRepository;

        public ProductRepository Products
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository();

                return _productRepository;
            }
        }

        private BrandAdRepository _brandAdRepository;

        public BrandAdRepository BrandAds
        {
            get
            {
                if (_brandAdRepository == null)
                    _brandAdRepository = new BrandAdRepository();

                return _brandAdRepository;
            }
        }

        private CategoryRepository _categoryRepository;

        public CategoryRepository Categories
        {
            get
            {
                if (_categoryRepository == null)
                    _categoryRepository = new CategoryRepository();

                return _categoryRepository;
            }
        }

        private MenuItemRepository _menuItemRepository;

        public MenuItemRepository MenuItems
        {
            get
            {
                if (_menuItemRepository == null)
                    _menuItemRepository = new MenuItemRepository();

                return _menuItemRepository;
            }
        }

        private ProductImageRepository _productImageRepository;

        public ProductImageRepository ProductImages
        {
            get
            {
                if (_productImageRepository == null)
                    _productImageRepository = new ProductImageRepository();

                return _productImageRepository;
            }
        }

        private ProductColorRepository _productColorRepository;

        public ProductColorRepository ProductColors
        {
            get
            {
                if (_productColorRepository == null)
                    _productColorRepository = new ProductColorRepository();

                return _productColorRepository;
            }
        }

        private CommentRepository _commentRepository;

        public CommentRepository Comments
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository();

                return _commentRepository;
            }
        }
    }
}