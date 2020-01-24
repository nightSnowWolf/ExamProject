using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Collections.Generic;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class SubtitleInfoRepository
    {
        private CatalogDbContext _dbContext;

        public SubtitleInfoRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public List<SubtitleInfoDto> GetEntityById(int id)
        {
            var mediaId = (from i in _dbContext.SubtitleInfos
                           where i.Media.GeneralVideoInfoId == id
                           select i.Id).FirstOrDefault();

            var result = (from s in _dbContext.SubtitleInfos
                          where s.MediaId == mediaId
                          select new SubtitleInfoDto
                          {
                              Id = s.Id,
                              Author = s.Author,
                              Language = s.Language,
                               SubtitleFormat = s.SubtitleFormat,
                               Note = s.Note
                          }).ToList();
            return result;
        }
    }
}
