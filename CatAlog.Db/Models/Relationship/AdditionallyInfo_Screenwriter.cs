using CatAlog.Db.Models.General;
using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.Relationship
{
    public class AdditionallyInfo_Screenwriter
    {
        public int AdditionallyInfoId { get; set; }
        public AdditionallyInfo AdditionallyInfo { get; set; }

        public int ScreenwriterId { get; set; }
        public Screenwriter Screenwriter { get; set; }
    }
}
