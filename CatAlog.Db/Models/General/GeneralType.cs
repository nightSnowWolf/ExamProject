using CatAlog.Db.Models.VideoTemplate;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class GeneralType
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public IEnumerable<GeneralVideoInfo> GeneralVideosInformation { get; set; }
    }
}
