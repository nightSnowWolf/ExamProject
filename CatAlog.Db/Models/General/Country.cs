using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<AdditionallyInfo_Country> AdditionallyInfo_Country { get; set; }
    }
}
