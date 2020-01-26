using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using Microsoft.EntityFrameworkCore;
using System;
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
            return _getEntities(_dbContext, id).ToList();
        }

        public List<string> GetQualityList()
        {
            return _getAllQuality(_dbContext).ToList();
        }

        public List<string> GetRelationList()
        {
            return _getAllRelation(_dbContext).ToList();
        }   
        
        public List<int> GetWidth()
        {
            return _getAllWidth(_dbContext).ToList();
        }

        public List<int> GetHeight()
        {
            return _getAllHeight(_dbContext).ToList();
        }       
        
        public List<string> GetVideoFormats()
        {
            return _getAllVideoFormats(_dbContext).ToList();
        }
             
        private static Func<CatalogDbContext, int, IEnumerable<VideoInfoDto>> _getEntities =
            EF.CompileQuery((CatalogDbContext db, int id) =>
            db.VideoInfos.Where(i => i.MediaId == id).Select(v => new VideoInfoDto 
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
            }));            

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllQuality = 
            EF.CompileQuery((CatalogDbContext db) => 
            db.VideoInfos.GroupBy(q => q.VideoQuality).Select(a => a.Key));

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllRelation =
            EF.CompileQuery((CatalogDbContext db) =>
            db.VideoInfos.GroupBy(r => r.Relation).Select(a => a.Key));

        private static Func<CatalogDbContext, IEnumerable<int>> _getAllWidth = 
            EF.CompileQuery((CatalogDbContext db) => 
            db.VideoInfos.GroupBy(w => w.ResolutionWidth).Select(t => t.Key));

        private static Func<CatalogDbContext, IEnumerable<int>> _getAllHeight =
            EF.CompileQuery((CatalogDbContext db) =>
            db.VideoInfos.GroupBy(h => h.ResolutionHeigth).Select(r => r.Key));

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllVideoFormats =
            EF.CompileQuery((CatalogDbContext db) =>
            db.VideoInfos.GroupBy(f => f.VideoFormat).Select(v => v.Key));
    }
}

