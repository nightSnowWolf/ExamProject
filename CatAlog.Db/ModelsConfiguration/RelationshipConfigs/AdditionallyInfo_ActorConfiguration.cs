using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AdditionallyInfo_ActorConfiguration : IEntityTypeConfiguration<AdditionallyInfo_Actor>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo_Actor> builder)
        {
            builder.HasKey(k => new { k.AdditionallyInfoId, k.ActorId });
            builder.HasOne(a => a.AdditionallyInfo).WithMany(c => c.AdditionallyInfo_Actor).HasForeignKey(k => k.AdditionallyInfoId);
            builder.HasOne(a => a.Actor).WithMany(c => c.AdditionallyInfo_Actors).HasForeignKey(k => k.ActorId);
            builder.HasData
                (
                    new AdditionallyInfo_Actor[]
                    {
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 1 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 2 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 3 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 4 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 5 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 6 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 7 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 8 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 9 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 1, ActorId = 10 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 11 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 12 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 13 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 14 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 15 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 16 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 17 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 18 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 19 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 2, ActorId = 20 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 21 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 22 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 23 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 24 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 25 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 26 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 27 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 28 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 29 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 30 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 31 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 32 },
                        new AdditionallyInfo_Actor() { AdditionallyInfoId = 3, ActorId = 33 },
                    }
                );
        }
    }
}
