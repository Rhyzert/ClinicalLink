using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain;
using Domain.Entidades;


namespace ClinicalLink.Infrastructure
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ReciclaNew");
        }
        /*        private IConfiguration _configuration;

                public SqlContext(IConfiguration configuration, DbContextOptions options) : base(options)
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

                    switch (typeDatabase)
                    {
                        case "PostgreSql":
                            optionsBuilder.UseNpgsql(connectionString);
                            break;


                    }*/
        //}

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Especialista> Especialistas { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Universidade> Universidades { get; set; }


    }
}
