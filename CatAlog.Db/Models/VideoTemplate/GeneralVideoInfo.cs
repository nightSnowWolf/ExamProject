using CatAlog.Db.Models.General;
using System.Collections.Generic;

namespace CatAlog.Db.Models.VideoTemplate
{
    public class GeneralVideoInfo
    {
        public int Id { get; set; }

        public int TemplateId { get; set; }
        public Template Template { get; set; }

        public int GeneralTypeId { get; set; }
        public GeneralType GeneralType { get; set; }

        public IEnumerable<RecordName> Names { get; set; }

        public string TitleImage { get; set; }

        public IEnumerable<Screenshots> Screenshots { get; set; }

        public string Duration { get; set; }

        public string ReleaseDate { get; set; }

        public string Description { get; set; }

        public float? Rating { get; set; }

        public AdditionallyInfo AdditionallyInformation { get; set; }

        public SerialInfo SerialInformation { get; set; }

        public Media Media { get; set; }
    }
}
