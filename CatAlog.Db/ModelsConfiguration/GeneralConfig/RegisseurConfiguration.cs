using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class RegisseurConfiguration : IEntityTypeConfiguration<Regisseur>
    {
        public void Configure(EntityTypeBuilder<Regisseur> builder)
        {
            builder.HasData
                (
                    new Regisseur[]
                    {
                        new Regisseur() { Id = 1, Name = "Джеймс Кэмерон" },
                        new Regisseur() { Id = 2, Name = "Джон Г. Эвилдсен" },
                        new Regisseur() { Id = 3, Name = "Абе Форсайт" },
                        new Regisseur() { Id = 4, Name = "Джастин Копеланд" },
                        new Regisseur() { Id = 5, Name = "Номура Кадзуя" },
                        new Regisseur() { Id = 6, Name = "Норихико Судо" }
                    }
                );
        }
    }
}
