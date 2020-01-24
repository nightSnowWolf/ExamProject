using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class MediaRepository
    {     
        private CatalogDbContext _dbContext;

        public MediaRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public MediaDto GetEntityById(int id)
        {
            var result = (from m in _dbContext.Medias
                          where m.GeneralVideoInfoId == id
                          select new MediaDto
                          {
                              Id = m.Id,
                              Size = m.Size
                          }).FirstOrDefault();

            return result;
        }
    }
}
