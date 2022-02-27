using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigiKalaMobileApp.Converters
{
    public class DiscountEndDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var discountEndDate = (DateTime)value;
            var diffrent = discountEndDate - DateTime.Now;

            return diffrent.Hours.ToString("00") + ":" + diffrent.Minutes.ToString("00") + ":" + diffrent.Seconds.ToString("00");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}