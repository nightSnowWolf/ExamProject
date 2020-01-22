using CatAlog.Db.Models.VideoTemplate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.VideoTemplateConfig
{
    public class SerialInfoConfiguration : IEntityTypeConfiguration<SerialInfo>
    {
        public void Configure(EntityTypeBuilder<SerialInfo> builder)
        {
            builder.HasData
                (
                    new SerialInfo[]
                    {
                        new SerialInfo() 
                        { 
                            Id = 1, 
                            CountSpecials = 0,
                            SeasonNumber = 18,
                            SerialVersion = "TV",
                            GeneralVideoInfoId = 6
                        }
                    }
                );
        }
    }
}
