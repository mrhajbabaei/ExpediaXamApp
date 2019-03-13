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
            if (value is Flight flight)
            {
                if (flight.ATD == "")
                    return $"Boarding {flight.STD} at Gate {flight.DepartureGateNumber}";

                return $"Boarding {flight.STA} at Gate {flight.ArrivalGateNumber}";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
