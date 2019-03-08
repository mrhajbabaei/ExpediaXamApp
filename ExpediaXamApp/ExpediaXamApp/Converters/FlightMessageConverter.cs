using ExpediaXamApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ExpediaXamApp.Converters
{
    class FlightMessageConverte : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Leg leg)
            {
                if ( leg.ATD != "" && leg.ATA != "" )
                    return "See you soon ;)";

                else if ( leg.ATD != "" )
                    return "Have a happy landing ;)";

                else
                    return "It's go time";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
