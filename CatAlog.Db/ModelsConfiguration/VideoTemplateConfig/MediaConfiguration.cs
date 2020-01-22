using CatAlog.Db.Models.VideoTemplate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.VideoTemplateConfig
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder.HasData
                (
                    new Media[]
                    {
                        new Media()
                        {
                            Id = 1, 
                            Size = 13.5f,
                            GeneralVideoInfoId = 1
                        },
                        new Media()
                        {
                            Id = 2,
                            Size = 8.25f,
                            GeneralVideoInfoId = 2
                        },
                        new Media()
                        {
                            Id = 3,
                            Size = 4.3f,
                            GeneralVideoInfoId = 3
                        },
                        new Media()
                        {
                            Id = 4,
                            Size = 7.8f,
                            GeneralVideoInfoId = 4
                        },
                        new Media()
                        {
                            Id = 5,
                            Size = 15.8f,
                            GeneralVideoInfoId = 5
                        },
                        new Media()
                        {
                            Id = 6,
                            Size = 24.9f,
                            GeneralVideoInfoId = 6
                        },
                    }
                );
        }
    }
}
