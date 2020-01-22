using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.General
{
    public class Screenshots 
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public int GeneralVideoInfoId { get; set; }
        public GeneralVideoInfo GeneralVideoInfo { get; set; }
    }
}
