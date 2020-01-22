using CatAlog.Db.Models.General;
using CatAlog.Db.Models.VideoTemplate;

namespace CatAlog.Db.Models.Relationship
{
    public class AdditionallyInfo_Regisseur
    {
        public int AdditionallyInfoId { get; set; }
        public AdditionallyInfo AdditionallyInfo { get; set; }

        public int RegisseurId { get; set; }
        public Regisseur Regisseur { get; set; }
    }
}
