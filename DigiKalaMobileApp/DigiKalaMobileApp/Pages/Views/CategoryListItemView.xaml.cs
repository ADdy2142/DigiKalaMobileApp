using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigiKalaMobileApp.Pages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryListItemView : ContentView
    {
        #region Properties

        public Category Category
        {
            get { return (Category)GetValue(CategoryProperty); }
            set { SetValue(CategoryProperty, value); }
        }

        public static readonly BindableProperty CategoryProperty = BindableProperty.Create("Category", typeof(Category), typeof(CategoryListItemView), null, propertyChanged: OnCategoryChanged);

        #endregion Properties

        public CategoryListItemView()
        {
            InitializeComponent();
        }

        private static void OnCategoryChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as CategoryListItemView;
            if (view == null)
                return;

            var category = (Category)newValue;
            if (category == null)
                return;

            view.LblTitle.Text = category.Title;
            view.CvGroups.ItemsSource = category.Groups;
        }

        private async void CvGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CvGroups.SelectedItem == null)
                return;

            await Application.Current.MainPage.Navigation.PushAsync(new CategoryPage());
            CvGroups.SelectedItem = null;
        }
    }
}