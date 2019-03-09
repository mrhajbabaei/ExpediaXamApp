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
            if (value is Leg leg)
            {
                if ((leg.ATA != "") || (leg.ATD != ""))
                {
                    if (leg.ATA != "")
                    {
                        if (DateTime.Parse(leg.ATA) > DateTime.Parse(leg.STA))
                            return "Delayed";

                        return "ON-Time";
                    }

                    if (leg.ATD != "")
                    {
                        if (DateTime.Parse(leg.ATD) > DateTime.Parse(leg.STD))
                            return "Delayed";

                        return "ON-Time";
                    }
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
