using CatAlog.Db.DbContexts;
using System.Collections.Generic;
using System.Linq;

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

        public List<string> GetAllTemplates()
        {
            return _dbContext.Templates.Select(s => s.Name).ToList();
        }
    }
}
