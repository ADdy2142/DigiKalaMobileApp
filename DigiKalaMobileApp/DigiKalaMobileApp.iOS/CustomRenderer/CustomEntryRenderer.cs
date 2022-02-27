using DigiKalaMobileApp.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(DigiKalaMobileApp.iOS.CustomRenderer.CustomEntryRenderer))]

namespace DigiKalaMobileApp.iOS.CustomRenderer
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            Control.BorderStyle = UIKit.UITextBorderStyle.None;
            Control.BackgroundColor = null;
        }
    }
}