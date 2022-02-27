using DigiKalaMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigiKalaMobileApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage()
        {
            InitializeComponent();
        }

        private void CvProductImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                var selectedItem = CvProductImages.SelectedItem as ProductImage;
                if (selectedItem == null)
                    return;

                var productImages = CvProductImages.ItemsSource.OfType<ProductImage>().ToList();
                int selectedIndex = productImages.IndexOf(selectedItem);
                CvcProductImages.Position = selectedIndex;
            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            CvcProductImages.Position = 1;
            CvcProductImages.Position = 0;
        }
    }
}