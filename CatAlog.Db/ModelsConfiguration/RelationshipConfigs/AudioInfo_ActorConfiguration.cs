using CatAlog.Db.Models.Relationship;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.RelationshipConfigs
{
    public class AudioInfo_ActorConfiguration : IEntityTypeConfiguration<AudioInfo_Actor>
    {
        public void Configure(EntityTypeBuilder<AudioInfo_Actor> builder)
        {
            builder.HasKey(k => new { k.AudioInfoId, k.ActorId });
            builder.HasOne(a => a.AudioInfo).WithMany(s => s.AudioInfo_Actors).HasForeignKey(k => k.AudioInfoId);
            builder.HasOne(a => a.Actor).WithMany(s => s.AudioInfo_Actors).HasForeignKey(k => k.ActorId);
            builder.HasData
                (
                    new AudioInfo_Actor[]
                    {
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 34},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 35},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 36},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 37},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 38},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 39},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 40},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 41},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 42},
                        new AudioInfo_Actor() { AudioInfoId = 5, ActorId = 43},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 44},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 45},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 46},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 47},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 48},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 49},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 50},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 51},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 52},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 53},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 54},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 55},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 56},
                        new AudioInfo_Actor() { AudioInfoId = 6, ActorId = 57},
                    }
                );
        }
    }
}
