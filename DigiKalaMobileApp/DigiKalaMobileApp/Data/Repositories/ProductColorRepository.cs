using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class ProductColorRepository
    {
        private readonly List<ProductColor> _productColors;

        public ProductColorRepository()
        {
            _productColors = new List<ProductColor>
            {
                new ProductColor { Id = 1, Title = "مشکی", Value = "#222222" },
                new ProductColor { Id = 2, Title = "سرمه ای", Value = "#37474F" },
                new ProductColor { Id = 3, Title = "سفید", Value = "#F5F5F5" }
            };
        }

        public IEnumerable<ProductColor> GetAll()
        {
            return _productColors;
        }
    }
}