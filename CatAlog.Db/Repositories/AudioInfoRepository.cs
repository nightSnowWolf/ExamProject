using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Collections.Generic;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class AudioInfoRepository
    {
        private CatalogDbContext _dbContext;

        public AudioInfoRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public List<AudioInfoDto> GetEntityById(int id)
        {
            var mediaId = (from i in _dbContext.AudioInfos
                           where i.Media.GeneralVideoInfoId == id
                           select i.Id).FirstOrDefault();

            var result = (from a in _dbContext.AudioInfos
                          where a.MediaId == mediaId
                          select new AudioInfoDto
                          {
                              Id = a.Id,
                              AudioFormat = a.AudioFormat,
                              Author = a.Author,
                              Bitrate = a.Bitrate,
                              Channel = a.Channel,
                              Frequency = a.Frequency,
                              Language = a.Language,
                              Note = a.Note,
                              Dubbings = a.AudioInfo_Actors.Select(d => d.Actor).Select(n => n.Name).ToList()
                          }).ToList();
            return result;
        }
    }
}
