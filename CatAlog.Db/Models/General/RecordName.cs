using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.General
{
    public class RecordName
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GeneralVideoInfoId { get; set; }
        public GeneralVideoInfo GeneralVideoInfo { get; set; }
    }
}
