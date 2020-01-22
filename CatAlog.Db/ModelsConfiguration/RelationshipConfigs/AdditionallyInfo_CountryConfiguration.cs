using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AdditionallyInfo_CountryConfiguration : IEntityTypeConfiguration<AdditionallyInfo_Country>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo_Country> builder)
        {
            builder.HasKey(k => new { k.AdditionallyInfoId, k.CountryId });
            builder.HasOne(a => a.AdditionallyInfo).WithMany(c => c.AdditionallyInfo_Country).HasForeignKey(k => k.AdditionallyInfoId);
            builder.HasOne(c => c.Country).WithMany(a => a.AdditionallyInfo_Country).HasForeignKey(k => k.CountryId);
            builder.HasData
                (
                    new AdditionallyInfo_Country[]
                    {
                        new AdditionallyInfo_Country() { AdditionallyInfoId = 1, CountryId = 1},
                        new AdditionallyInfo_Country() { AdditionallyInfoId = 2, CountryId = 2},
                        new AdditionallyInfo_Country() { AdditionallyInfoId = 3, CountryId = 3},
                        new AdditionallyInfo_Country() { AdditionallyInfoId = 4, CountryId = 1},
                        new AdditionallyInfo_Country() { AdditionallyInfoId = 5, CountryId = 5},
                        new AdditionallyInfo_Country() { AdditionallyInfoId = 6, CountryId = 4}
                    }
                );
        }
    }
}
