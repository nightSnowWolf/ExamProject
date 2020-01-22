using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AdditionallyInfo_CompanyConfiguration : IEntityTypeConfiguration<AdditionallyInfo_Company>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo_Company> builder)
        {
            builder.HasKey(k => new { k.AdditionallyInfoId, k.CompanyId });
            builder.HasOne(a => a.AdditionallyInfo).WithMany(c => c.AdditionallyInfo_Company).HasForeignKey(k => k.AdditionallyInfoId);
            builder.HasOne(c => c.Company).WithMany(a => a.AdditionallyInfo_Company).HasForeignKey(k => k.CompanyId);
            builder.HasData
                (
                    new AdditionallyInfo_Company[]
                    {
                        new AdditionallyInfo_Company() { AdditionallyInfoId = 1, CompanyId = 1},
                        new AdditionallyInfo_Company() { AdditionallyInfoId = 2, CompanyId = 2},
                        new AdditionallyInfo_Company() { AdditionallyInfoId = 3, CompanyId = 1},
                        new AdditionallyInfo_Company() { AdditionallyInfoId = 4, CompanyId = 3},
                        new AdditionallyInfo_Company() { AdditionallyInfoId = 5, CompanyId = 2},
                        new AdditionallyInfo_Company() { AdditionallyInfoId = 6, CompanyId = 3},
                    }
                );
        }
    }
}
