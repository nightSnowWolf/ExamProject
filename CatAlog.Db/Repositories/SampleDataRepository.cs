using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Collections.Generic;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class SampleDataRepository
    {
        private CatalogDbContext _dbContext;

        public SampleDataRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public List<SampleDataDto> GetAll(string type)
        {
            var index = _dbContext.GeneralTypes.FirstOrDefault(t => t.Type == type).Id;

            var result = (from s in _dbContext.GeneralVideoInfos
                          where s.GeneralTypeId == index
                          select new SampleDataDto
                          {
                              Id = s.Id,
                              Names = s.Names.Select(n => n.Name).ToList(),
                              Rating = s.Rating,
                              ReleaseDate = s.ReleaseDate,
                              TitleImage = s.TitleImage,
                              Genres = s.AdditionallyInformation
                                        .AdditionallyInfo_Genre
                                        .Select(a => a.Genre)
                                        .Select(n => n.Name)
                                        .ToList()
                          }).ToList();

            return result;
        }
    }
}
