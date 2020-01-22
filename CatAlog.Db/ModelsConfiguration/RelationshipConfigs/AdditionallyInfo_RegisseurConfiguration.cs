using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AdditionallyInfo_RegisseurConfiguration : IEntityTypeConfiguration<AdditionallyInfo_Regisseur>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo_Regisseur> builder)
        {
            builder.HasKey(k => new { k.AdditionallyInfoId, k.RegisseurId });
            builder.HasOne(a => a.AdditionallyInfo).WithMany(r => r.AdditionallyInfo_Regisseur).HasForeignKey(k => k.AdditionallyInfoId);
            builder.HasOne(r => r.Regisseur).WithMany(a => a.AdditionallyInfo_Regisseur).HasForeignKey(k => k.RegisseurId);
            builder.HasData
                (
                    new AdditionallyInfo_Regisseur[]
                    {
                        new AdditionallyInfo_Regisseur() { AdditionallyInfoId = 1, RegisseurId = 1 },
                        new AdditionallyInfo_Regisseur() { AdditionallyInfoId = 2, RegisseurId = 2 },
                        new AdditionallyInfo_Regisseur() { AdditionallyInfoId = 3, RegisseurId = 3 },
                        new AdditionallyInfo_Regisseur() { AdditionallyInfoId = 4, RegisseurId = 4 },
                        new AdditionallyInfo_Regisseur() { AdditionallyInfoId = 5, RegisseurId = 5 },
                        new AdditionallyInfo_Regisseur() { AdditionallyInfoId = 6, RegisseurId = 6 },
                    }
                );
        }
    }
}
