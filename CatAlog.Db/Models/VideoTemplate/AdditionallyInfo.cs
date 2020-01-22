using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.VideoTemplate
{
    public class AdditionallyInfo
    {
        public int Id { get; set; }

        public int GeneralVideoInformationId { get; set; }
        public GeneralVideoInfo GeneralVideoInformation { get; set; }

        public IEnumerable<AdditionallyInfo_Genre> AdditionallyInfo_Genre { get; set; }

        public IEnumerable<AdditionallyInfo_Country> AdditionallyInfo_Country { get; set; }

        public IEnumerable<AdditionallyInfo_Company> AdditionallyInfo_Company { get; set; }

        public IEnumerable<AdditionallyInfo_Regisseur> AdditionallyInfo_Regisseur { get; set; }

        public IEnumerable<AdditionallyInfo_Screenwriter> AdditionallyInfo_Screenwriter { get; set; }

        public IEnumerable<AdditionallyInfo_Actor> AdditionallyInfo_Actor { get; set; }

        public string Note { get; set; }
        
        public string ReleaseAuthor { get; set; }
    }
}
