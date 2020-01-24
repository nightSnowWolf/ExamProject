using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    public class EpisodeNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is SerialInfoDto info)
            {
                var numbers = info.SeriesNumber;
                var names = info.SeriesName;
                if ((numbers != null && numbers.Count != 0) && (names != null && names.Count != 0))
                {
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        builder.Append($"{numbers[i]}. {names[i]}.\n");
                    }
                    return builder.ToString();
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
