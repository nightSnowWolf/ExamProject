using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    public class VideoInformationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is VideoInfoDto video)
            {
                if (parameter != null && parameter is string viewSwitch)
                {
                    if (viewSwitch == "short")
                    {
                        return GetShortInfoString(video);
                    }
                    else if(viewSwitch == "full")
                    {
                        return GetFullInfoString(video);
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        private string GetShortInfoString(VideoInfoDto video)
        {
            string id = "Video: ";
            string note = video.Note != null ? video.Note + "\n" : "";
            string quality = video.VideoQuality != null ? video.VideoQuality + " | " : "";
            string width = video.ResolutionWidth.ToString();
            string heigth = video.ResolutionHeigth.ToString();
            string resolution = width != null && heigth != null ? width + 'x' + heigth :
                                heigth != null && width == null ? heigth + "p " : "";
            string relation = video.Relation != null ? " (" + video.Relation + ") | " : "";
            string videoFormat = video.VideoFormat != null ? video.VideoFormat + " | " : "";
            string bitrate = video.Bitrate != null ? video.Bitrate.ToString() + " kb/s | " : "";
            string frameRate = video.FrameRate != null ? video.FrameRate.ToString() + " FPS" : "";

            return $"{id}{note}{quality}{resolution}{relation}{videoFormat}{bitrate}{frameRate}";
        }

        private string GetFullInfoString(VideoInfoDto video)
        {
            string id = "Video: \n";
            string note = video.Note != null ? video.Note + "\n" : "";
            string quality = video.VideoQuality != null ? "\tКачество видео: " + video.VideoQuality + '\n' : "";
            string videoFormat = video.VideoFormat != null ? "\tФормат: " + video.VideoFormat + '\n' : "";
            string relation = video.Relation != null ? "\tСоотношение: " + video.Relation + '\n' : "";
            string bitrate = video.Bitrate != null ? "\tБитрейт: " + video.Bitrate.ToString() + " kb/s\n" : "";

            string width = video.ResolutionWidth.ToString();
            string heigth = video.ResolutionHeigth.ToString();
            string resolution = width != null && heigth != null ? "\tРазрешение: " + width + 'x' + heigth + '\n' :
                                heigth != null && width == null ? "\tРазрешение: " + heigth + "p\n" : "";

            string frameRate = video.FrameRate != null ? "\tЧастота: " + video.FrameRate.ToString() + " FPS\n" : "";

            return $"{id}{note}{quality}{videoFormat}{bitrate}{resolution}{relation}{frameRate}";
        }
    }
}
