using CatAlog.Db.Models.General;
using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.Relationship
{
    public class AdditionallyInfo_Country
    {
        public int AdditionallyInfoId { get; set; }
        public AdditionallyInfo AdditionallyInfo { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
