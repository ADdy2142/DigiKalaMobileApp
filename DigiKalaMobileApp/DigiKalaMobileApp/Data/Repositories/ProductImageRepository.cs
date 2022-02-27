using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class ProductImageRepository
    {
        private readonly List<ProductImage> _productImages;

        public ProductImageRepository()
        {
            _productImages = new List<ProductImage>
            {
                new ProductImage { Id = 1, ImageUrl = "category_image_01.png" },
                new ProductImage { Id = 2, ImageUrl = "category_image_02.png" },
                new ProductImage { Id = 3, ImageUrl = "category_image_03.jpg" },
                new ProductImage { Id = 4, ImageUrl = "category_image_04.png" },
                new ProductImage { Id = 5, ImageUrl = "category_image_05.png" }
            };
        }

        public IEnumerable<ProductImage> GetAll()
        {
            return _productImages;
        }
    }
}