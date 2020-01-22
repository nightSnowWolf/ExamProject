using System.Collections.Generic;

namespace CatAlog.Db.Models.VideoTemplate
{
    public class Media
    {
        public int Id { get; set; }

        public int GeneralVideoInfoId { get; set; }
        public GeneralVideoInfo GeneralVideoInfo { get; set; }

        public IEnumerable<VideoInfo> VideoInformation { get; set; }

        public IEnumerable<AudioInfo> AudioInformation { get; set; }

        public IEnumerable<SubtitleInfo> SubtitleInformation { get; set; }

        public float? Size { get; set; }
    }
}