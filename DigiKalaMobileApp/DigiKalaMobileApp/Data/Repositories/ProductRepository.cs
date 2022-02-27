using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    ImageUrl = "product_image_01.png",
                    Title = "عنوان محصول اول",
                    Price = 130000,
                    Discount = 30,
                    DiscountEndDate = DateTime.Now.AddMinutes(777),
                    Qty = 4,
                    Score = 4.5,
                    Visit = 45
                },
                new Product
                {
                    Id = 2,
                    ImageUrl = "product_image_02.png",
                    Title = "عنوان محصول دوم",
                    Price = 176900,
                    Discount = 13,
                    DiscountEndDate = DateTime.Now.AddMinutes(214),
                    Qty = 4,
                    Score = 3.2,
                    Visit = 12
                },
                new Product
                {
                    Id = 3,
                    ImageUrl = "product_image_03.png",
                    Title = "عنوان محصول سوم",
                    Price = 475000,
                    Discount = 10,
                    DiscountEndDate = DateTime.Now.AddMinutes(463),
                    Qty = 4,
                    Score = 4.5,
                    Visit = 129
                },
                new Product
                {
                    Id = 4,
                    ImageUrl = "product_image_04.png",
                    Title = "عنوان محصول چهارم",
                    Price = 87900,
                    Discount = 40,
                    DiscountEndDate = DateTime.Now.AddMinutes(5),
                    Qty = 4,
                    Score = 3.2,
                    Visit = 12
                },
                new Product
                {
                    Id = 5,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 256,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 0,
                    Score = 3.9
                },
                new Product
                {
                    Id = 6,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 112,
                    Discount = 5,
                    DiscountEndDate = DateTime.Now.AddHours(14),
                    Qty = 0,
                    Score = 3.9
                },
                new Product
                {
                    Id = 7,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 45,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 43,
                    Score = 4.5
                },
                new Product
                {
                    Id = 8,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 39,
                    Discount = 12,
                    DiscountEndDate = DateTime.Now.AddHours(2),
                    Qty = 0,
                    Score = 3.9
                },
                new Product
                {
                    Id = 9,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 213,
                    Discount = 5,
                    DiscountEndDate = DateTime.Now.AddHours(14),
                    Qty = 0,
                    Score = 3.9
                },
                new Product
                {
                    Id = 10,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 198,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 12,
                    Score = 3.9
                },
                new Product
                {
                    Id = 11,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 62,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 42,
                    Score = 4
                },
                new Product
                {
                    Id = 12,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 23,
                    Discount = 3,
                    DiscountEndDate = DateTime.Now.AddHours(18),
                    Qty = 1,
                    Score = 2.3
                },
                new Product
                {
                    Id = 13,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 271,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 56,
                    Score = 4.1
                },
                new Product
                {
                    Id = 14,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 123,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 0,
                    Score = 4.1
                },
                new Product
                {
                    Id = 15,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 94,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 56,
                    Score = 2.8
                },
                new Product
                {
                    Id = 16,
                    ImageUrl = "product_image_01.png",
                    Title = "هدفون بیسیم مدل i6",
                    Price = 87900,
                    Visit = 25,
                    Discount = 0,
                    DiscountEndDate = null,
                    Qty = 56,
                    Score = 4.7
                },
                new Product
                {
                    Id = 17,
                    ImageUrl = "product_image_01.png",
                    Title = "عنوان محصول",
                    Price = 14300000,
                    Visit = 132,
                    Discount = 18,
                    DiscountEndDate = DateTime.Now + TimeSpan.FromDays(1),
                    Qty = 0,
                    Score = 4.5
                }
            };
        }

        public IEnumerable<Product> GetProductsWithDiscount()
        {
            return _products.Where(p => p.Discount > 0).Take(10);
        }

        public IEnumerable<MostVisitedProduct> GetMostVisitedProducts(int count = 12)
        {
            int index = 1;

            return _products.OrderByDescending(p => p.Visit).Take(count).Select(p => new MostVisitedProduct
            {
                Index = index++,
                Id = p.Id,
                Title = p.Title,
                ImageUrl = p.ImageUrl,
                Visit = p.Visit
            });
        }

        public IEnumerable<Product> GetProductsByCategory()
        {
            return _products;
        }

        public IEnumerable<Product> GetSimilarProducts()
        {
            return _products.Where(p => p.Qty > 0).Take(6);
        }
    }
}