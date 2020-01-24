using System.Collections.Generic;

namespace CatAlog.Db.Models.DtoModels.VideoModels
{
    public class AdditionallyInfoDto
    {
        public int Id { get; set; }

        public List<string> Genres { get; set; }

        public List<string> Countries { get; set; }

        public List<string> Companies { get; set; }

        public string ReleaseAuthor { get; set; } // не подключен

        public List<string> Regisseurs { get; set; }

        public List<string> Screenwriters { get; set; }

        public List<string> Actors { get; set; }

        public string Note { get; set; }
    }
}
