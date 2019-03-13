using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using ExpediaXamApp.Models;
using Xamarin.Forms;

namespace ExpediaXamApp.Converters
{
    class TimeColorConverter : IValueConverter
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
                            return Color.Red;

                        return Color.Green;
                    }

                    if (DateTime.Parse(flight.ATD) > DateTime.Parse(flight.STD))
                        return Color.Red;

                    return Color.Green;
                }

                return Color.Black;
            }

            return Color.White;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
