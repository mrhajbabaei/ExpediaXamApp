using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExpediaXamApp.Models;
using Xamarin.Forms;

namespace ExpediaXamApp.Converters
{
    class LegToGateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Flight flight)
            {
                if (flight.ATD == "")
                    return flight.DepartureGateNumber.ToString();

                return flight.ArrivalGateNumber.ToString();
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
