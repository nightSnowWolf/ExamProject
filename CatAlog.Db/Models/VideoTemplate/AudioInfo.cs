using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.VideoTemplate
{
    public class AudioInfo
    {
        public int Id { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }

        public IEnumerable<AudioInfo_Actor> AudioInfo_Actors { get; set; }

        public string AudioFormat { get; set; }

        public string Language { get; set; }

        public string Channel { get; set; }

        public float? Frequency { get; set; }

        public float? Bitrate { get; set; }

        public string Author { get; set; }

        public string Note { get; set; }
    }
}