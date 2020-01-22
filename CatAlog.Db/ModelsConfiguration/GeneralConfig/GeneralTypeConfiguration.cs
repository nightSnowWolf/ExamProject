using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class GeneralTypeConfiguration : IEntityTypeConfiguration<GeneralType>
    {
        public void Configure(EntityTypeBuilder<GeneralType> builder)
        {
            builder.HasData
                (
                    new GeneralType[]
                    {
                        new GeneralType() { Id = 1, Type = "Film" },
                        new GeneralType() { Id = 2, Type = "Animation" },
                        new GeneralType() { Id = 3, Type = "Anime" }
                    }
                );
        }
    }
}
