using Android.Content;
using DigiKalaMobileApp.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(DigiKalaMobileApp.Droid.CustomRenderer.CustomEntryRenderer))]

namespace DigiKalaMobileApp.Droid.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            Control.SetPadding(0, 0, 0, 0);
        }
    }
}