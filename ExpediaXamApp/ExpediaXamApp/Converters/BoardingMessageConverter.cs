using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Schema;
using ExpediaXamApp.Models;
using Xamarin.Forms;

namespace ExpediaXamApp.Converters
{
    class BoardingMessageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Leg leg)
            {
                if (leg.ATD == "")
                    return $"Boarding {leg.STD} at Gate {leg.DepartureGateNumber}";

                return $"Boarding {leg.STA} at Gate {leg.ArrivalGateNumber}";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
