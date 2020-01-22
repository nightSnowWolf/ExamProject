using CatAlog.Db.Models.Relationship;
using System.Collections.Generic;

namespace CatAlog.Db.Models.General
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<AdditionallyInfo_Genre> AdditionallyInfo_Genre { get; set; } 
    }
}
