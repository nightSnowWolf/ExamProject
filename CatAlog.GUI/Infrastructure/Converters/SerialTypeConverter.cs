using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    public class SerialTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is SerialInfoDto serial)
            {
                var seriesCount = serial.SeriesNumber?.Count;
                var isSeries = serial.SeriesNumber != null ? true : false;
                string note = serial.Note != null ? '[' + serial.Note + ']' : "";

                if (seriesCount != 0 && serial.CountSpecials != 0)
                {
                    return string.Format($"{serial.Version} ({seriesCount} эп. + {serial.CountSpecials} спзшл.) {note}");
                }
                else if (seriesCount != 0)
                {
                    return string.Format($"{serial.Version} ({seriesCount} эп.) {note}");
                }
                else if (!isSeries)
                {
                    return string.Format($"{serial.Version} {note}");
                }
                else if (!isSeries && serial.CountSpecials == 1)
                {
                    return string.Format($"{serial.Version} - спэшл. {note}");
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
