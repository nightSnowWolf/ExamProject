﻿using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class GenreConfigurationcs : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData
                (
                    new Genre[]
                    {
                        new Genre() { Id = 1, Name = "Фантастика" },
                        new Genre() { Id = 2, Name = "Боевик" },
                        new Genre() { Id = 3, Name = "Триллер" },
                        new Genre() { Id = 4, Name = "Криминал" },
                        new Genre() { Id = 5, Name = "Комедия" },
                        new Genre() { Id = 6, Name = "Ужасы" },
                        new Genre() { Id = 7, Name = "Комикс" },
                        new Genre() { Id = 8, Name = "Приключения" },
                        new Genre() { Id = 9, Name = "Фэнтези" }
                    }
                );
        }
    }
}
