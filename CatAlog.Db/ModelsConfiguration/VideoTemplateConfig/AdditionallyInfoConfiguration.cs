using CatAlog.Db.Models.VideoTemplate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.VideoTemplateConfig
{
    public class AdditionallyInfoConfiguration : IEntityTypeConfiguration<AdditionallyInfo>
    {
        public void Configure(EntityTypeBuilder<AdditionallyInfo> builder)
        {
            builder.HasData
                (
                    new AdditionallyInfo[]
                    {
                        new AdditionallyInfo()
                        {
                             Id = 1, 
                            GeneralVideoInformationId = 1
                        },
                        new AdditionallyInfo()
                        {
                             Id = 2,
                             GeneralVideoInformationId = 2
                        },
                        new AdditionallyInfo()
                        {
                             Id = 3,
                             GeneralVideoInformationId = 3
                        },
                        new AdditionallyInfo()
                        {
                             Id = 4,
                             GeneralVideoInformationId = 4,
                             Note = "Посмотреть как будет возможность."
                        },
                        new AdditionallyInfo()
                        {
                             Id = 5,
                             GeneralVideoInformationId = 5
                        },
                        new AdditionallyInfo()
                        {
                             Id = 6,
                             GeneralVideoInformationId = 6,
                             ReleaseAuthor = "Free Releasers Team \"SORA\""
                        },
                    }
                );
        }
    }
}
