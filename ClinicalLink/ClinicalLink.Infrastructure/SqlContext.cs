using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain;
using Domain.Entidades;
using Microsoft.Identity.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace ClinicalLink.Infrastructure
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) 
        {
            
        }

      /*  private IConfiguration _configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=ClinicalLink;" +
              "User Id=postgres;" +
              "Password=kadugay;");*/

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<Especialista> Especialistas { get; set; }
        public DbSet<Supervisao> Supervisoes { get; set; }
        public DbSet<Universidade> Universidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }


    }
}
