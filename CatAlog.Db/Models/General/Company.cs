using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<AdditionallyInfo_Company> AdditionallyInfo_Company { get; set; }
    }
}
