using ClinicalLink.Infrastructure.Interface;
using ClinicalLink.Infrastructure.Repositories;
using ClinicalLink.Infrastructure;
using DomainService.Interfaces;
using DomainService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationService.Application;
using ApplicationService.Interface;

namespace Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers().AddNewtonsoftJson(options => {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepositorySql>();
            services.AddScoped<IUsuarioRepository, UsuarioRepositorySql>();
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IAvaliacaoApplication, AvaliacaoApplication>();
            services.AddScoped<IUsuarioApplication, UsuarioApplication>();

            services.AddDbContext<SqlContext>(options =>
            {
                options.UseNpgsql(Configuration.GetConnectionString("Default"),
                    assembly => assembly.MigrationsAssembly(typeof(SqlContext).Assembly.FullName));
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ClinicalLink", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Application v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
