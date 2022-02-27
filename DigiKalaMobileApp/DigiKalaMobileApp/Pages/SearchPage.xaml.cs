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
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            EntSearch.Focus();
        }

        private async void CvSearchMatches_ChildAdded(object sender, ElementEventArgs e)
        {
            await CvSearchMatches.TranslateTo(CvSearchMatches.TranslationX, 0, 300, Easing.Linear);
        }

        private async void EntSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            CvSearchMatches.CancelAnimations();

            var deviceHeight = Application.Current.MainPage.Height;
            await CvSearchMatches.TranslateTo(CvSearchMatches.TranslationX, deviceHeight, 0, Easing.Linear);
        }
    }
}