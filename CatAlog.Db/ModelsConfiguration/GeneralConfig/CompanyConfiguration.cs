using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData
                (
                    new Company[]
                    {
                        new Company() { Id = 1, Name = "20th Century Fox" },
                        new Company() { Id = 2, Name = "Studio 3Hz" },
                        new Company() { Id = 3, Name = "OLM" }
                    }
                );
        }
    }
}
