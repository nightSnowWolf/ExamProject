using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using Microsoft.EntityFrameworkCore;
using System;
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
            return _getEntities(_dbContext, id).ToList(); 
        }

        public List<string> GetFormats()
        {
            return _getAllFormats(_dbContext).ToList();
        }

        public List<string> GetChanels()
        {
            return _getAllChanels(_dbContext).ToList();
        }    
        
        public List<string> GetLanguages()
        {
            return _getAllLanguages(_dbContext).ToList();
        }     
        
        public List<string> GetAuthors()
        {
            return _getAllAuthors(_dbContext).ToList();
        }    
                          
        private static Func<CatalogDbContext, int, IEnumerable<AudioInfoDto>> _getEntities =
            EF.CompileQuery((CatalogDbContext db, int id) => 
            db.AudioInfos.Where(i => i.MediaId == id).Select(a => new AudioInfoDto 
            {
                Id = a.Id,
                AudioFormat = a.AudioFormat,
                Author = a.Author,
                Bitrate = a.Bitrate,
                Channel = a.Channel,
                Frequency = a.Frequency,
                Language = a.Language,
                Note = a.Note
            }));

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllFormats = 
            EF.CompileQuery((CatalogDbContext db) => 
            db.AudioInfos.GroupBy(f => f.AudioFormat).Select(n => n.Key));

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllChanels =
            EF.CompileQuery((CatalogDbContext db) =>
            db.AudioInfos.GroupBy(c => c.Channel).Select(s => s.Key));

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllLanguages =
            EF.CompileQuery((CatalogDbContext db) =>
            db.AudioInfos.GroupBy(l => l.Language).Select(k => k.Key));

        private static Func<CatalogDbContext, IEnumerable<string>> _getAllAuthors =
            EF.CompileQuery((CatalogDbContext db) =>
            db.AudioInfos.GroupBy(a => a.Author).Select(k => k.Key));
    }
}
