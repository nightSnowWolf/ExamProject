using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData
                (
                    new Country[]
                    {
                        new Country() { Id = 1, Name = "США" },
                        new Country() { Id = 2, Name = "Франция" },
                        new Country() { Id = 3, Name = "Австралия" },
                        new Country() { Id = 4, Name = "Великобритания" },
                        new Country() { Id = 5, Name = "Япония" }
                    }
                );
        }
    }
}
