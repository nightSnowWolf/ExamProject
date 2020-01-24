using System.Collections.Generic;

namespace CatAlog.Db.Models.DtoModels.VideoModels
{
    public class SerialInfoDto
    {
        public int Id { get; set; }

        public List<string> SeriesNumber { get; set; }

        public List<string> SeriesName { get; set; }

        public int? SeasonNumber { get; set; }

        public string Version { get; set; }

        public int? CountSpecials { get; set; }

        public string Note { get; set; }
    }
}
