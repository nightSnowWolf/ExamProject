using CatAlog.Db.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatAlog.Db.Repositories
{
    public class CatalogRepository
    {
        

        public void GetAll()
        {
            using (CatalogDbContext db = new CatalogDbContext())
            {
                var result = db.GeneralVideoInfos
                    .Include(s => s.AdditionallyInformation)
                    .Include(r => r.GeneralType)
                    .Include(t => t.Template)
                    .ToList();
            }
        }
    }
}
