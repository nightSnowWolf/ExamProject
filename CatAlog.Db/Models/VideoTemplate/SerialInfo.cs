using System.Collections.Generic;

namespace CatAlog.Db.Models.VideoTemplate
{
    public class SerialInfo
    {
        public int Id { get; set; }

        public int GeneralVideoInfoId { get; set; }
        public GeneralVideoInfo GeneralVideoInfo { get; set; }

        public IEnumerable<Episode> Episodes { get; set; }

        public int? SeasonNumber { get; set; }

        public string SerialVersion { get; set; }

        public int? CountSpecials { get; set; }

        public string Note { get; set; }
    }
}