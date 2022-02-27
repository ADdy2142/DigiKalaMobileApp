using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class BannerRepository
    {
        private readonly List<Banner> _banners;

        public BannerRepository()
        {
            _banners = new List<Banner>
            {
                new Banner { ImageUrl = "banner_item_01.jpg" },
                new Banner { ImageUrl = "banner_item_02.jpg" },
                new Banner { ImageUrl = "banner_item_03.jpg" },
                new Banner { ImageUrl = "banner_item_04.jpg" },
                new Banner { ImageUrl = "banner_item_05.jpg" },
                new Banner { ImageUrl = "banner_item_06.jpg" }
            };
        }

        public IEnumerable<Banner> GetAll()
        {
            return _banners;
        }
    }
}