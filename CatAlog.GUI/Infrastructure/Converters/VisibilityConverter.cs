using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    public class VisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {            
            if(value != null && value is string visibilityType)
            {
                return visibilityType != "" ? Visibility.Visible : Visibility.Collapsed;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
