using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatAlog.Db.Repositories
{
    public class SharedDataRepository
    {
        private CatalogDbContext _dbContext;

        public SharedDataRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public List<string> GetAllTypes()
        {
            return _dbContext.GeneralTypes.Select(t => t.Type).ToList();
        }
    }
}
