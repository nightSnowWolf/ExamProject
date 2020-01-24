using System;
using System.Collections.Generic;

namespace CatAlog.Db.Models.DtoModels.VideoModels
{
    public class SampleDataDto
    {
        public int Id { get; set; }

        public List<string> Names { get; set; }

        public string TitleImage { get; set; }

        public float? Rating { get; set; }

        public string ReleaseDate { get; set; }

        public List<string> Genres { get; set; }
    }
}
