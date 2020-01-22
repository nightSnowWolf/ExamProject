using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AdditionallyInfo_GenreConfiguration : IEntityTypeConfiguration<AdditionallyInfo_Genre>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo_Genre> builder)
        {
            builder.HasKey(k => new { k.AdditionallyInfoId, k.GenreId });
            builder.HasOne(a => a.AdditionallyInfo).WithMany(g => g.AdditionallyInfo_Genre).HasForeignKey(k => k.AdditionallyInfoId);
            builder.HasOne(g => g.Genre).WithMany(a => a.AdditionallyInfo_Genre).HasForeignKey(k => k.GenreId);
            builder.HasData
                (
                    new AdditionallyInfo_Genre[]
                    {
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 1 , GenreId = 1 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 1 , GenreId = 2 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 1 , GenreId = 7 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 2 , GenreId = 8 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 2 , GenreId = 3 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 2 , GenreId = 4 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 2 , GenreId = 5 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 3 , GenreId = 2 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 3 , GenreId = 4 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 4 , GenreId = 8 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 4 , GenreId = 7 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 5 , GenreId = 1 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 5 , GenreId = 3 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 5 , GenreId = 5 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 5 , GenreId = 6 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 6 , GenreId = 8 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 6 , GenreId = 2 },
                        new AdditionallyInfo_Genre(){ AdditionallyInfoId = 6 , GenreId = 3 }
                    }
                );
        }
    }
}
