using System.Collections.Generic;

namespace CatAlog.Db.Models.DtoModels.VideoModels
{
    public class GeneralInfoDto
    {
        public int Id { get; set; }

        public string Template { get; set; }

        public string GeneralType { get; set; }

        public List<string> Names { get; set; }

        public string TitleImage { get; set; }

        public List<string> Screenshots { get; set; }

        public string Duration { get; set; }

        public string ReleaseDate { get; set; }

        public string Description { get; set; }

        public float? Rating { get; set; }
    }
}
