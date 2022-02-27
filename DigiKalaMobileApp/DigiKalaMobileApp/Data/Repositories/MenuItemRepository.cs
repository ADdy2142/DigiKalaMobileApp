using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Shapes;

namespace DigiKalaMobileApp.Data.Repositories
{
    public class MenuItemRepository
    {
        private readonly List<MenuItem> _menuItems;

        public MenuItemRepository()
        {
            var resources = Xamarin.Forms.Application.Current.Resources;

            _menuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Title = "پروفایل",
                    Icon = resources["ProfileIcon"] as PathGeometry
                },
                new MenuItem
                {
                    Title = "سبد خرید",
                    Icon = resources["ShoppingCartIcon"] as PathGeometry
                },
                new MenuItem
                {
                    Title = "دسته بندی ها",
                    Icon = resources["CategoriesIcon"] as PathGeometry
                },
                new MenuItem
                {
                    Title = "خانه",
                    Icon = resources["HomeIcon"] as PathGeometry
                }
            };
        }

        public IEnumerable<MenuItem> GetAll()
        {
            return _menuItems;
        }
    }
}