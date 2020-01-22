using CatAlog.Db.Models.VideoTemplate;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class Template
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<GeneralVideoInfo> GeneralVideosInformation { get; set; }
    }
}
