﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using InstrumentSelector.Models;
using InstrumentSelector.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InstrumentSelector
{
    public class Startup
    {
        // Added for MySQL (also added Pomelo.EntityFrameworkCore.MySql Nuget package
        private IHostingEnvironment environment;

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            // Added for MySQL
            environment = env;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddTransient<ISelectionRepository, FakeSelectionRepository>();
            services.AddTransient<ISelectionRepository, SelectionRepository>();
            //services.AddTransient<IInstrumentRepository, FakeInstrumentRepository>();
            services.AddTransient<IInstrumentRepository, InstrumentRepository>();
            //services.AddTransient<ICommentRepository, FakeCommentRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Added for MySQL
            if (environment.IsDevelopment())
            {
                services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
                   Configuration["ConnectionStrings:MsSqlConnection"]));
            }
            else if (environment.IsProduction())
            {
                services.AddDbContext<AppDbContext>(options => options.UseMySql(
                    Configuration["ConnectionStrings:MySqlConnection"]));
            }

            /*   // For Mac OS with SQLite
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlite(
                    Configuration["ConnectionStrings:SQLiteConnection"]));
            */
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Edited for EF
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AppDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
                // Create or update the database and apply migrations.
                context.Database.Migrate();

                // Add a comment or two as sample/test data.
                SeedData.Seed(context);
            }
    }
}

