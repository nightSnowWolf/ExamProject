using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class ScreenwriterConfiguration : IEntityTypeConfiguration<Screenwriter>
    {
        public void Configure(EntityTypeBuilder<Screenwriter> builder)
        {
            builder.HasData
                (
                    new Screenwriter[]
                    {
                        new Screenwriter() { Id = 1, Name = "Хаяси Наоки" }
                    }
                );
        }
    }
}
