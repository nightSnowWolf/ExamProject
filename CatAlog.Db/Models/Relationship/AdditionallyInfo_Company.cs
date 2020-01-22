using CatAlog.Db.Models.General;
using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.Relationship
{
    public class AdditionallyInfo_Company
    {
        public int AdditionallyInfoId { get; set; }
        public AdditionallyInfo AdditionallyInfo { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
