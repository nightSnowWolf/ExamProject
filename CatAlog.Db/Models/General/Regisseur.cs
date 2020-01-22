using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class Regisseur
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<AdditionallyInfo_Regisseur> AdditionallyInfo_Regisseur { get; set; }
    }
}
