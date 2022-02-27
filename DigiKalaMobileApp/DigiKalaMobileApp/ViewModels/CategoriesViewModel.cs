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
    public class CategoriesViewModel : ViewModelBase
    {
        private ObservableCollection<Category> _categories;

        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }

        public CategoriesViewModel()
        {
            Categories = new ObservableCollection<Category>();

            GetCategories();
        }

        private void GetCategories()
        {
            Categories = new ObservableCollection<Category>(UnitOfWork.Categories.GetAll());
        }
    }
}