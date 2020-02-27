﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using TravelEurope.WebAPI.Database;
using TravelEurope.WebAPI.Services;

namespace TravelEurope.WebAPI
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IDrzavaService, DrzavaService>();
            services.AddScoped<IGradService, GradService>();
            services.AddScoped<ITuristickaRutaServices, TuristickaRutaServices>();
            services.AddScoped<ITuristickiVodicServices, TuristickiVodicServices>();
            services.AddScoped<IStraniJezikService, StraniJezikService>();
            services.AddScoped<IVoziloService, VoziloService>();
            services.AddScoped<IVozacService, VozacService>();
            services.AddScoped<ITipVozilaService, TipVozilaService>();
            services.AddScoped<IMarkaVozilaService, MarkaVozilaService>();
            services.AddScoped<IVrstaGorivaService, VrstaGorivaService>();
            services.AddScoped<IStatusVozilaService, StatusVozilaService>();
            services.AddScoped<IStatusVozacaService, StatusVozacaService>();
            services.AddScoped<IRuteSlikeService, RuteSlikeService>();
            services.AddScoped<IRezervacijaService, RezervacijaService>();


#pragma warning disable CS0618 // Type or member is obsolete
            services.AddAutoMapper();
            #pragma warning restore CS0618 // Type or member is obsolete

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "TravelEurope API v1", Version = "v1" });
            });
            services.AddScoped(p => new TravelEurope_Context(p.GetService<DbContextOptions<TravelEurope_Context>>()));

            var connection = @"Server=.;Database=TravelEurope_RS2-1;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<TravelEurope_Context>(options => options.UseSqlServer(connection));
        }

        //protected void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer("Server=.;Database=TravelEurope_RS2-1;Trusted_Connection=True;ConnectRetryCount=0");
        //    base.OnConfiguring(builder);
        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TravelEurope V1");
            });

            app.UseMvc();
        }
    }
}
