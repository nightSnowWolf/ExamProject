using CatAlog.Db.Models.VideoTemplate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.VideoTemplateConfig
{
    public class EpisodeConfiguration : IEntityTypeConfiguration<Episode>
    {
        public void Configure(EntityTypeBuilder<Episode> builder)
        {
            builder.HasOne(s => s.SerialInformation).WithMany(e => e.Episodes).HasForeignKey(k => k.SerialInformationId);
            builder.HasData
                (
                    new Episode[]
                    {
                        new Episode() { Id = 1,  Number = "1",  Name = "Сражение красавиц за честь и престиж!", SerialInformationId = 1 },
                        new Episode() { Id = 2,  Number = "2",  Name = "Советы для братьев-бойцов!", SerialInformationId = 1 },
                        new Episode() { Id = 3,  Number = "3",  Name = "Возвращение домой!", SerialInformationId = 1 },
                        new Episode() { Id = 4,  Number = "4",  Name = "Дрейден против Ирис. Прошлое, настоящее и будущее!", SerialInformationId = 1 },
                        new Episode() { Id = 5,  Number = "5",  Name = "Команда Иви и спасательный отряд Покемонов!", SerialInformationId = 1 },
                        new Episode() { Id = 6,  Number = "6",  Name = "Лига Юновы начинается!", SerialInformationId = 1 },
                        new Episode() { Id = 7,  Number = "7",  Name = "Задача: одолеть соперника!", SerialInformationId = 1 },
                        new Episode() { Id = 8,  Number = "8",  Name = "Потерянные на лиге!", SerialInformationId = 1 },
                        new Episode() { Id = 9,  Number = "9",  Name = "Сильная стратегия – это главное!", SerialInformationId = 1 },
                        new Episode() { Id = 10, Number = "10", Name = "Секретное оружие Камерона!", SerialInformationId = 1 },
                        new Episode() { Id = 11, Number = "11", Name = "Эволюция Лиги Юновы!", SerialInformationId = 1 },
                        new Episode() { Id = 12, Number = "12", Name = "Новые места, знакомые лица!", SerialInformationId = 1 },
                        new Episode() { Id = 13, Number = "13", Name = "Меня зовут Н!", SerialInformationId = 1 },
                        new Episode() { Id = 14, Number = "14", Name = "В городе новый гим - лидер!", SerialInformationId = 1 },
                        new Episode() { Id = 15, Number = "15", Name = "Заговор команды Плазмы!", SerialInformationId = 1 },
                        new Episode() { Id = 16, Number = "16", Name = "Огонь ранчо Флокеси!", SerialInformationId = 1 },
                        new Episode() { Id = 17, Number = "17", Name = "Спасая Бревиари!", SerialInformationId = 1 },
                        new Episode() { Id = 18, Number = "18", Name = "Прибрежный патруль Покемонов!", SerialInformationId = 1 },
                        new Episode() { Id = 19, Number = "19", Name = "Огни жаркой встречи!", SerialInformationId = 1 },
                        new Episode() { Id = 20, Number = "20", Name = "Команда Плазма манипулирует покемонами!", SerialInformationId = 1 },
                        new Episode() { Id = 21, Number = "21", Name = "Секреты из тумана!", SerialInformationId = 1 },
                        new Episode() { Id = 22, Number = "22", Name = "Мяут, Колрес и соперничество команд!", SerialInformationId = 1 },
                        new Episode() { Id = 23, Number = "23", Name = "Эш и Н: столкновение идеалов!", SerialInformationId = 1 },
                        new Episode() { Id = 24, Number = "24", Name = "Команда Плазма и церемония пробуждения!", SerialInformationId = 1 },
                        new Episode() { Id = 25, Number = "25", Name = "Что лежит за правдой и идеалами!", SerialInformationId = 1 },
                        new Episode() { Id = 26, Number = "26", Name = "Прощай, Юнова!Вперед, к новым приключениям!", SerialInformationId = 1 },
                        new Episode() { Id = 27, Number = "27", Name = "Опасность!Сладкая как мёд!", SerialInformationId = 1 },
                        new Episode() { Id = 28, Number = "28", Name = "Сайлан и дело свидетельницы Пурлойн!", SerialInformationId = 1 },
                        new Episode() { Id = 29, Number = "29", Name = "Коронация короля Гребешков!", SerialInformationId = 1 },
                        new Episode() { Id = 30, Number = "30", Name = "Остров Иллюзий!", SerialInformationId = 1 },
                        new Episode() { Id = 31, Number = "31", Name = "Поймать Ротома!", SerialInformationId = 1 },
                        new Episode() { Id = 32, Number = "32", Name = "Пираты Деколор!", SerialInformationId = 1 },
                        new Episode() { Id = 33, Number = "33", Name = "Баттерфри и я!", SerialInformationId = 1 },
                        new Episode() { Id = 34, Number = "34", Name = "Дорога, ведущая к прощанию!", SerialInformationId = 1 },
                        new Episode() { Id = 35, Number = "35", Name = "В поисках Желания!", SerialInformationId = 1 },
                        new Episode() { Id = 36, Number = "36", Name = "НЛО на острове Капация!", SerialInformationId = 1 },
                        new Episode() { Id = 37, Number = "37", Name = "Журналист Покемонов из другого региона!", SerialInformationId = 1 },
                        new Episode() { Id = 38, Number = "38", Name = "Покемон необычной расцветки!", SerialInformationId = 1 },
                        new Episode() { Id = 39, Number = "39", Name = "Загадка пустынного острова!", SerialInformationId = 1 },
                        new Episode() { Id = 40, Number = "40", Name = "Вперёд, Гогоут!", SerialInformationId = 1 },
                        new Episode() { Id = 41, Number = "41", Name = "Встреча кометы героя!", SerialInformationId = 1 },
                        new Episode() { Id = 42, Number = "42", Name = "Спасение гима Стриатон!", SerialInformationId = 1 },
                        new Episode() { Id = 43, Number = "43", Name = "Новый шокирующий член Команды Р!", SerialInformationId = 1 },
                        new Episode() { Id = 44, Number = "44", Name = "Всего хорошего и до новых встреч!", SerialInformationId = 1 },
                        new Episode() { Id = 45, Number = "45", Name = "Мечта продолжается!", SerialInformationId = 1 }
                    }
                );
        }
    }
}
