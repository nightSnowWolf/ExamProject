using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Collections.Generic;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class VideoInfoRepository
    {
        private CatalogDbContext _dbContext;

        public VideoInfoRepository()
        {
            _dbContext = new CatalogDbContext();
        }
                
        public List<VideoInfoDto> GetEntityById(int id)
        {
            var mediaId = (from i in _dbContext.VideoInfos
                          where i.Media.GeneralVideoInfoId == id
                          select i.Id).FirstOrDefault();

            var result = (from v in _dbContext.VideoInfos
                          where v.MediaId == mediaId
                          select new VideoInfoDto
                          {
                              Id = v.Id,
                              Bitrate = v.Bitrate,
                              FrameRate = v.FrameRate,
                              Note = v.Note,
                              Relation = v.Relation,
                              ResolutionHeigth = v.ResolutionHeigth,
                              ResolutionWidth = v.ResolutionWidth,
                              VideoFormat = v.VideoFormat,
                              VideoQuality = v.VideoQuality
                          }).ToList();
            return result;
        }
    }
}
