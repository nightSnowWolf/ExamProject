using CatAlog.Db.DbContexts;
using CatAlog.Db.Models.DtoModels.VideoModels;
using System.Linq;

namespace CatAlog.Db.Repositories
{
    public class AdditionallyInfoRepository
    {
        private CatalogDbContext _dbContext;

        public AdditionallyInfoRepository()
        {
            _dbContext = new CatalogDbContext();
        }

        public AdditionallyInfoDto GetEntityById(int id)
        {
            int AdditionalId = (from a in _dbContext.AdditionallyInfos 
                                where a.GeneralVideoInformationId == id 
                                select a.Id).FirstOrDefault();

            var result = (from a in _dbContext.AdditionallyInfos
                          where a.Id == AdditionalId
                          select new AdditionallyInfoDto
                          {
                              Id = a.Id,
                              Actors = a.AdditionallyInfo_Actor.Select(s => s.Actor).Select(n => n.Name).ToList(),
                              Companies = a.AdditionallyInfo_Company.Select(c => c.Company).Select(n => n.Name).ToList(),
                              Genres = a.AdditionallyInfo_Genre.Select(g => g.Genre).Select(n => n.Name).ToList(),
                              Countries = a.AdditionallyInfo_Country.Select(c => c.Country).Select(n => n.Name).ToList(),
                              Regisseurs = a.AdditionallyInfo_Regisseur.Select(r => r.Regisseur).Select(n => n.Name).ToList(),
                              Screenwriters = a.AdditionallyInfo_Screenwriter.Select(s => s.Screenwriter).Select(n => n.Name).ToList(),
                              ReleaseAuthor = a.ReleaseAuthor,
                              Note = a.Note
                          }).FirstOrDefault();

            return result;
        }
    }
}
