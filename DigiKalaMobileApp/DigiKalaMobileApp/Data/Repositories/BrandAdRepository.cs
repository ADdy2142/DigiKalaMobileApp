using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class BrandAdRepository
    {
        private readonly List<BrandAd> _brandAds;

        public BrandAdRepository()
        {
            _brandAds = new List<BrandAd>
            {
                new BrandAd { ImageUrl = "banner_item_02.jpg" },
                new BrandAd { ImageUrl = "banner_item_03.jpg" },
                new BrandAd { ImageUrl = "banner_item_04.jpg" },
                new BrandAd { ImageUrl = "banner_item_05.jpg" }
            };
        }

        public IEnumerable<BrandAd> GetAll()
        {
            return _brandAds;
        }
    }
}