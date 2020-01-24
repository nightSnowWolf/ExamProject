using CatAlog.Db.Models.VideoTemplate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.VideoTemplateConfig
{
    public class SubtitleInfoConfiguration : IEntityTypeConfiguration<SubtitleInfo>
    {
        public void Configure(EntityTypeBuilder<SubtitleInfo> builder)
        {
            builder.HasOne(m => m.Media).WithMany(s => s.SubtitleInformation).HasForeignKey(k => k.MediaId);
            builder.HasData
                (
                    new SubtitleInfo[]
                    {
                         new SubtitleInfo()
                         {
                             Id = 1,
                             Author = "Киномания",
                             Language = "Английский",
                             SubtitleFormat = "SRT",
                             Note = "ненормативная лексика",
                             MediaId = 1
                         },
                         new SubtitleInfo()
                         {
                             Id = 2,
                             Author = "Юрий Сербин",
                             Language = "Русский",
                             SubtitleFormat = "ASS",
                             Note = "ненормативная лексика",
                             MediaId = 1
                         },
                         new SubtitleInfo()
                         {
                             Id = 3,
                             Author = "Ziggy Team & Serick Sub",
                             Language = "Английский",
                             SubtitleFormat = "ASS",
                             Note = "ненормативная лексика",
                             MediaId = 3
                         },
                         new SubtitleInfo()
                         {
                             Id = 4,
                             Author = "Киномания",
                             Language = "Русский",
                             SubtitleFormat = "SRT",
                             Note = "ненормативная лексика",
                             MediaId = 4
                         },
                         new SubtitleInfo()
                         {
                             Id = 5,
                             Author = "Ziggy Team & Serick Sub",
                             Language = "Русский",
                             SubtitleFormat = "SRT",
                             Note = "ненормативная лексика",
                             MediaId = 4
                         }
                    }
                );
        }
    }
}
