using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    class SubtitleInformationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is SubtitleInfoDto subtitle)
            {
                if (parameter != null && parameter is string viewSwitch)
                {
                    if (viewSwitch == "short")
                    {
                        return GetShortInfoString(subtitle);
                    }
                    else if (viewSwitch == "full")
                    {
                        return GetFullInfoString(subtitle);
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        private string GetShortInfoString(SubtitleInfoDto subtitle)
        {
            string id = "Subtitle: ";
            string language = subtitle.Language != null ? subtitle.Language : "";
            string format = subtitle.SubtitleFormat != null ? " | " + subtitle.SubtitleFormat : "";
            string author = subtitle.Author != null ? " | " + subtitle.Author : "";
            string note = subtitle.Note != null ? '(' + subtitle.Note + ')' : "";

            return $"{id}{language}{format}{author}{note}";
        }

        private string GetFullInfoString(SubtitleInfoDto subtitle)
        {
            string id = "Subtitle: \n";
            string language = subtitle.Language != null ? "\tЯзык: " + subtitle.Language + '\n' : "";
            string format = subtitle.SubtitleFormat != null ? "\tФормат: " + subtitle.SubtitleFormat + '\n' : "";
            string author = subtitle.Author != null ? "\tАвтор: " + subtitle.Author + '\n' : "";
            string note = subtitle.Note != null ? "\tТип: " + subtitle.Note + '\n' : "";

            return $"{id}{language}{format}{author}{note}";
        }
    }
}