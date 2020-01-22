using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class Screenwriter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<AdditionallyInfo_Screenwriter> AdditionallyInfo_Screenwriter { get; set; }
    }
}
