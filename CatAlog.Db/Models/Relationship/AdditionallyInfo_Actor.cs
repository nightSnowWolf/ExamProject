using CatAlog.Db.Models.General;
using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.Relationship
{
    public class AdditionallyInfo_Actor
    {
        public int AdditionallyInfoId { get; set; }
        public AdditionallyInfo AdditionallyInfo { get; set; }

        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
