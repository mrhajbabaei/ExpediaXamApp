using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExpediaXamApp.Models;
using Xamarin.Forms;

namespace ExpediaXamApp.Converters
{
    class TimeMessageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Flight flight)
            {
                if ((flight.ATA != "") || (flight.ATD != ""))
                {
                    if (flight.ATA != "")
                    {
                        if (DateTime.Parse(flight.ATA) > DateTime.Parse(flight.STA))
                            return "Delayed";

                        return "ON-Time";
                    }

                    if (DateTime.Parse(flight.ATD) > DateTime.Parse(flight.STD))
                        return "Delayed";

                    return "ON-Time";
                }

                return "Unknown";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
