using CatAlog.Db.Models.General;
using CatAlog.Db.Models.Relationship;
using CatAlog.Db.Models.VideoTemplate;
using CatAlog.Db.ModelsConfiguration.GeneralConfig;
using CatAlog.Db.ModelsConfiguration.RelationshipConfigs;
using CatAlog.Db.ModelsConfiguration.VideoTemplateConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CatAlog.Db.DbContexts
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Country> Countrys { get; set; }
        public DbSet<GeneralType> GeneralTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<RecordName> RecordNames { get; set; }
        public DbSet<Regisseur> Regisseurs { get; set; }
        public DbSet<Screenwriter> Screenwriters { get; set; }
        public DbSet<Template> Templates { get; set; }

        public DbSet<AdditionallyInfo_Actor> AdditionallyInfo_Actors { get; set; }
        public DbSet<AdditionallyInfo_Company> AdditionallyInfo_Companys { get; set; }
        public DbSet<AdditionallyInfo_Country> AdditionallyInfo_Countrys { get; set; }
        public DbSet<AdditionallyInfo_Genre> AdditionallyInfo_Genres { get; set; }
        public DbSet<AdditionallyInfo_Regisseur> AdditionallyInfo_Regisseurs { get; set; }
        public DbSet<AdditionallyInfo_Screenwriter> AdditionallyInfo_Screenwriters { get; set; }
        public DbSet<AudioInfo_Actor> AudioInfo_Actors { get; set; }

        public DbSet<AdditionallyInfo> AdditionallyInfos { get; set; }
        public DbSet<AudioInfo> AudioInfos { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<GeneralVideoInfo> GeneralVideoInfos { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<SerialInfo> SerialInfos { get; set; }
        public DbSet<SubtitleInfo> SubtitleInfos { get; set; }
        public DbSet<VideoInfo> VideoInfos { get; set; }

        public CatalogDbContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite("Filename=catalog.db");
            builder.UseLoggerFactory(LoggerProvider);
        }

        public static readonly ILoggerFactory LoggerProvider = LoggerFactory.Create(builder =>
        {
            builder.AddProvider(new LoggerProvider());   
        });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Actor>(new ActorConfiguration());
            modelBuilder.ApplyConfiguration<Company>(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
            modelBuilder.ApplyConfiguration<GeneralType>(new GeneralTypeConfiguration());
            modelBuilder.ApplyConfiguration<Genre>(new GenreConfigurationcs());
            modelBuilder.ApplyConfiguration<RecordName>(new RecordNameConfiguration());
            modelBuilder.ApplyConfiguration<Regisseur>(new RegisseurConfiguration());
            modelBuilder.ApplyConfiguration<Screenshots>(new ScreenshotsConfiguration());
            modelBuilder.ApplyConfiguration<Screenwriter>(new ScreenwriterConfiguration());
            modelBuilder.ApplyConfiguration<Template>(new TemplateConfiguration());
            
            modelBuilder.ApplyConfiguration<AdditionallyInfo_Actor>(new AdditionallyInfo_ActorConfiguration());
            modelBuilder.ApplyConfiguration<AudioInfo_Actor>(new AudioInfo_ActorConfiguration());
            modelBuilder.ApplyConfiguration<AdditionallyInfo_Company>(new AdditionallyInfo_CompanyConfiguration());
            modelBuilder.ApplyConfiguration<AdditionallyInfo_Country>(new AdditionallyInfo_CountryConfiguration());
            modelBuilder.ApplyConfiguration<AdditionallyInfo_Genre>(new AdditionallyInfo_GenreConfiguration());
            modelBuilder.ApplyConfiguration<AdditionallyInfo_Regisseur>(new AdditionallyInfo_RegisseurConfiguration());
            modelBuilder.ApplyConfiguration<AdditionallyInfo_Screenwriter>(new AdditionallyInfo_ScreenwriterConfiguration());

            modelBuilder.ApplyConfiguration<AdditionallyInfo>(new AdditionallyInfoConfiguration());
            modelBuilder.ApplyConfiguration<AudioInfo>(new AudioInfoConfiguration());
            modelBuilder.ApplyConfiguration<Episode>(new EpisodeConfiguration());
            modelBuilder.ApplyConfiguration<GeneralVideoInfo>(new GeneralVideoInfoConfiguration());
            modelBuilder.ApplyConfiguration<Media>(new MediaConfiguration());
            modelBuilder.ApplyConfiguration<SerialInfo>(new SerialInfoConfiguration());
            modelBuilder.ApplyConfiguration<SubtitleInfo>(new SubtitleInfoConfiguration());
            modelBuilder.ApplyConfiguration<VideoInfo>(new VideoInfoConfiguration());
        }
    }
}
