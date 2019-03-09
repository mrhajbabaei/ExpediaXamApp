using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExpediaXamApp.Models;
using Xamarin.Forms;

namespace ExpediaXamApp.Converters
{
    class LegToDepartureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Leg leg)
            {
                if (leg.ATD == "")
                    return leg.Departure;

                return leg.Arrival;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
