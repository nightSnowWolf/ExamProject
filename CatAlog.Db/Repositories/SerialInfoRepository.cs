using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class SerialInfoRepository
    {
        private CatalogDbContext _dbContext;

        public SerialInfoRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public SerialInfoDto GetGetEntityById(int id)
        {
            int serialId = (from s in _dbContext.SerialInfos 
                            where s.GeneralVideoInfoId == id 
                            select s.Id).FirstOrDefault();

            var result = (from s in _dbContext.SerialInfos
                          where s.Id == serialId
                          select new SerialInfoDto
                          {
                              Id = s.Id,
                              CountSpecials = s.CountSpecials,
                              Note = s.Note,
                              SeasonNumber = s.SeasonNumber,
                              Version = s.SerialVersion,
                              SeriesNumber = s.Episodes.Select(n => n.Number).ToList(),
                              SeriesName = s.Episodes.Select(n => n.Name).ToList()
                          }).FirstOrDefault();

            return result;
        }
    }
}
