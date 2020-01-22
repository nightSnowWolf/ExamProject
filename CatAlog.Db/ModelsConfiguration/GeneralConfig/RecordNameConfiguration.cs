using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class RecordNameConfiguration : IEntityTypeConfiguration<RecordName>
    {
        public void Configure(EntityTypeBuilder<RecordName> builder)
        {
            builder.HasOne(g => g.GeneralVideoInfo).WithMany(r => r.Names).HasForeignKey(k => k.GeneralVideoInfoId);
            builder.HasData
                (
                    new RecordName[]
                    {
                        new RecordName() { Id = 1,  Name = "Terminator 2: Judgment Day", GeneralVideoInfoId = 1 },
                        new RecordName() { Id = 2,  Name = "Терминатор 2: Судный день",  GeneralVideoInfoId = 1 },
                        new RecordName() { Id = 3,  Name = "Inferno",                    GeneralVideoInfoId = 2 },
                        new RecordName() { Id = 4,  Name = "Инферно",                    GeneralVideoInfoId = 2 },
                        new RecordName() { Id = 5,  Name = "Little Monsters",            GeneralVideoInfoId = 3 },
                        new RecordName() { Id = 6,  Name = "Маленькие чудовища",         GeneralVideoInfoId = 3 },
                        new RecordName() { Id = 7,  Name = "Batman: Hush",               GeneralVideoInfoId = 4 },
                        new RecordName() { Id = 8,  Name = "Бэтмен: Тихо",               GeneralVideoInfoId = 4 },
                        new RecordName() { Id = 9,  Name = "Black Fox",                  GeneralVideoInfoId = 5 },
                        new RecordName() { Id = 10, Name = "Чёрная лиса",                GeneralVideoInfoId = 5 },
                        new RecordName() { Id = 11, Name = "Pokemon: Black and White - Adventures in Unova",  GeneralVideoInfoId = 6 },
                        new RecordName() { Id = 12, Name = "Покемон: Чёрное и Белое - Приключения в Юнове", GeneralVideoInfoId = 6 }
                    }
                );
        }
    }
}
