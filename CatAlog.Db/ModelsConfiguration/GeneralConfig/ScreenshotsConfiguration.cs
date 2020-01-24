using CatAlog.Db.Models.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatAlog.Db.ModelsConfiguration.GeneralConfig
{
    public class ScreenshotsConfiguration : IEntityTypeConfiguration<Screenshots>
    {
        public void Configure(EntityTypeBuilder<Screenshots> builder)
        {
            builder.HasOne(g => g.GeneralVideoInfo).WithMany(s => s.Screenshots).HasForeignKey(k => k.GeneralVideoInfoId);
            builder.HasData
                (
                    new Screenshots[]
                    {
                        new Screenshots(){ Id = 1,  GeneralVideoInfoId = 1, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Terminator 2\01.png" },
                        new Screenshots(){ Id = 2,  GeneralVideoInfoId = 1, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Terminator 2\02.png" },
                        new Screenshots(){ Id = 3,  GeneralVideoInfoId = 1, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Terminator 2\03.png" },
                        new Screenshots(){ Id = 4,  GeneralVideoInfoId = 2, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Inferno\01.png" },
                        new Screenshots(){ Id = 5,  GeneralVideoInfoId = 2, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Inferno\02.png" },
                        new Screenshots(){ Id = 6,  GeneralVideoInfoId = 2, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Inferno\03.png" },
                        new Screenshots(){ Id = 7,  GeneralVideoInfoId = 3, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Little Monsters\01.png" },
                        new Screenshots(){ Id = 8,  GeneralVideoInfoId = 3, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Little Monsters\02.png" },
                        new Screenshots(){ Id = 9,  GeneralVideoInfoId = 3, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Little Monsters\03.png" },
                        new Screenshots(){ Id = 10, GeneralVideoInfoId = 4, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Batman - Hush\01.png" },
                        new Screenshots(){ Id = 11, GeneralVideoInfoId = 4, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Batman - Hush\02.png" },
                        new Screenshots(){ Id = 12, GeneralVideoInfoId = 4, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Batman - Hush\03.png" },
                        new Screenshots(){ Id = 13, GeneralVideoInfoId = 4, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Batman - Hush\04.png" },
                        new Screenshots(){ Id = 14, GeneralVideoInfoId = 5, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Black fox\01.png" },
                        new Screenshots(){ Id = 15, GeneralVideoInfoId = 5, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Black fox\02.png" },
                        new Screenshots(){ Id = 16, GeneralVideoInfoId = 5, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Black fox\03.png" },
                        new Screenshots(){ Id = 17, GeneralVideoInfoId = 6, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Pokemon, Black and White - Adventures in Unova\01.png" },
                        new Screenshots(){ Id = 18, GeneralVideoInfoId = 6, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Pokemon, Black and White - Adventures in Unova\02.png" },
                        new Screenshots(){ Id = 19, GeneralVideoInfoId = 6, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Pokemon, Black and White - Adventures in Unova\03.png" },
                        new Screenshots(){ Id = 20, GeneralVideoInfoId = 6, Path = @"L:\ExamProject\CatAlog\CatAlog.GUI\bin\Debug\netcoreapp3.1\Scrinshots\Pokemon, Black and White - Adventures in Unova\04.png" },
                    }
                );
        }
    }
}

                                
                                
                                
                                