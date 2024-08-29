using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain;
using Domain.Entidades;


namespace ClinicalLink.Infrastructure
{
    public class ClinicalLinkDbContext : DbContext
    {
        private IConfiguration _configuration;

        public ClinicalLinkDbContext(IConfiguration configuration,DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var connectionString = _configuration.GetConnectionString(typeDatabase);

            if (typeDatabase == "Postgresql")
            {
                optionsBuilder.UseNpgsql(connectionString);
            }

            /*            switch (typeDatabase) 
                        {
                            case "PostgreSql": 
                                optionsBuilder.UseNpgsql(connectionString);
                                break;


                        }*/
        }

        public DbSet<Avaliacao> Avaliacoes { get; set; }

    }
}
