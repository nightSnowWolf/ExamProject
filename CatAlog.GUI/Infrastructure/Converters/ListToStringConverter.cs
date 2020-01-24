using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    public class ListToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is List<string> list)
            {
                return string.Join(", ", list.ToArray());
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
