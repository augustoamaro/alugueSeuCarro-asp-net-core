﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AlugueSeuCarro.Models;
using AlugueSeuCarro.AcessoDados.Interfaces;
using AlugueSeuCarro.AcessoDados.Repositorios;

namespace AlugueSeuCarro
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
            

            services.AddDbContext<Contexto>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexao")));
            services.AddIdentity<Usuario, NiveisAcesso>().AddDefaultUI().AddEntityFrameworkStores<Contexto>();

            services.ConfigureApplicationCookie(opcoes =>
            { 
                opcoes.Cookie.HttpOnly = true;
                opcoes.ExpireTimeSpan = TimeSpan.FromMinutes(50);
                opcoes.LoginPath = "/Usuarios/Login";
                opcoes.SlidingExpiration = true;
            });

            services.Configure<IdentityOptions>(opcoes =>
                {
                    opcoes.Password.RequireDigit = false;
                    opcoes.Password.RequireLowercase = false;
                    opcoes.Password.RequireNonAlphanumeric = false;
                    opcoes.Password.RequireUppercase = false;
                    opcoes.Password.RequiredLength = 6;
                    opcoes.Password.RequiredUniqueChars = 1;
                });

            services.AddScoped<INivelAcessoRepositorio, NivelAcessoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IContaRepositorio, ContaRepositorio>();
            services.AddScoped<ICarroRepositorio, CarroRepositorio>();
            services.AddScoped<IAluguelRepositorio, AluguelRepositorio>();
            

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Usuarios}/{action=Login}/{id?}");
            });
        }
    }
}
