using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class TemplateConfiguration : IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.HasData
                (
                    new Template[]
                    {
                        new Template() { Id = 1, Name = "Video" },
                        new Template() { Id = 2, Name = "Game" }
                    }
                );
        }
    }
}
