using CatAlog.Db.Models.DtoModels.VideoModels;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CatAlog.GUI.Infrastructure.Converters
{
    public class AudioInformationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is AudioInfoDto audio)
            {
                if (parameter != null && parameter is string viewSwitch)
                {
                    if (viewSwitch == "short")
                    {
                        return GetShortInfoString(audio);
                    }
                    else if (viewSwitch == "full")
                    {
                        return GetFullInfoString(audio);
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        private string GetShortInfoString(AudioInfoDto audio)
        {
            var id = "Audio track " + audio.Id.ToString() + ": ";
            var format = audio.AudioFormat != null ? audio.AudioFormat + " | " : "";
            var frequency = audio.Frequency != 0 ? audio.Frequency + " kHz | " : "";
            var channel = audio.Channel != null ? audio.Channel + " ch | " : "";
            var bitrate = audio.Bitrate != 0 ? audio.Bitrate + " kbps " : "";
            var language = audio.Language != null ? "\nLanguage: " + audio.Language + " " : "";

            var translation = audio.Note != null && audio.Author != null ? audio.Note + " (" + audio.Author + ")." :
                              audio.Note != null ? audio.Author + '.' :
                              audio.Author != null ? audio.Author + '.' : "";

            return $"{id}{format}{frequency}{channel}{bitrate}{language}{translation}";
        }

        private string GetFullInfoString(AudioInfoDto audio)
        {
            var id = "Audio track " + audio.Id.ToString() + ":\n";
            var format = audio.AudioFormat != null ? "\tFormat: " + audio.AudioFormat + '\n' : "";
            var channel = audio.Channel != null ? "\tChannels: " + audio.Channel + " ch\n" : "";
            var frequency = audio.Frequency != 0 ? "\tFrequency: " + audio.Frequency + " kHz\n" : "";
            var bitrate = audio.Bitrate != 0 ? "\tBitrate: " + audio.Bitrate + " kbps\n" : "";
            var language = audio.Language != null ? "\tLanguage: " + audio.Language + '\n' : "";

            var translation = audio.Author != null && audio.Note != null ? "\tAuthor: " + audio.Author + "\n\tType: " + audio.Note :
                              audio.Author != null ? "\tAuthor: " + audio.Author :
                              audio.Note != null ? "\tType: " + audio.Note : "";

            return $"{id}{format}{channel}{frequency}{bitrate}{language}{translation}";
        }
    }
}
