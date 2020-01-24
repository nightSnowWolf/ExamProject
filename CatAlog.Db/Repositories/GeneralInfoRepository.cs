using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class GeneralInfoRepository
    {
        private CatalogDbContext _dbContext;

        public GeneralInfoRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public GeneralInfoDto GetEntityById(int id)
        {
            var result = (from r in _dbContext.GeneralVideoInfos
                          where r.Id == id
                          select new GeneralInfoDto
                          {
                              Id = r.Id,
                              Template = r.Template.Name,
                              GeneralType = r.GeneralType.Type,
                              Names = r.Names.Select(n => n.Name).ToList(),
                              Description = r.Description,
                              Duration = r.Duration,
                              Rating = r.Rating,
                              ReleaseDate = r.ReleaseDate,
                              TitleImage = r.TitleImage,
                              Screenshots = r.Screenshots.Select(s => s.Path).ToList(),
                          }).FirstOrDefault();
            
            return result;
        }

    }
}
