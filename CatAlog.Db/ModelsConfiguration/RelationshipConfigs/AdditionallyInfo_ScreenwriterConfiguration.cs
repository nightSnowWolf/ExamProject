using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AdditionallyInfo_ScreenwriterConfiguration : IEntityTypeConfiguration<AdditionallyInfo_Screenwriter>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo_Screenwriter> builder)
        {
            builder.HasKey(k => new { k.AdditionallyInfoId, k.ScreenwriterId });
            builder.HasOne(a => a.AdditionallyInfo).WithMany(s => s.AdditionallyInfo_Screenwriter).HasForeignKey(k => k.AdditionallyInfoId);
            builder.HasOne(s => s.Screenwriter).WithMany(a => a.AdditionallyInfo_Screenwriter).HasForeignKey(k => k.ScreenwriterId);
            builder.HasData
                (
                    new AdditionallyInfo_Screenwriter[]
                    {
                        new  AdditionallyInfo_Screenwriter() { AdditionallyInfoId = 4, ScreenwriterId = 1 },
                        new  AdditionallyInfo_Screenwriter() { AdditionallyInfoId = 6, ScreenwriterId = 1 }
                    }
                );
        }
    }
}
