using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using af.assessment.api.Data;
using af.assessment.api.Services;
using af.assessment.api.Stores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace af.assessment.api
{
    public class Startup
    {
        private readonly string CORS_POLICY = "CorsPolicy";
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication();

            services.AddTransient<IVaccineStore, VaccineStore>();
            services.AddTransient<IVaccineService, VaccineService>();
            services.AddTransient<IRegisterService, RegisterService>();
            services.AddTransient<IRegisterStore, RegisterStore>();


            // Connection String to Postgres Database : 
            var connectionString = Configuration["ConnectionStrings:Postgres"];
            services.AddDbContext<VaccineDbContext>(options =>
                options.UseNpgsql(connectionString));
            services.AddDbContext<RegisterDbContext>(options =>
               options.UseNpgsql(connectionString));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = "v1",
                    Title = "Swager Api for the Digitized Child Vaccine Application",
                    Description = "An API that is so so cool."
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                s.IncludeXmlComments($"{AppContext.BaseDirectory}{Path.DirectorySeparatorChar}{Assembly.GetExecutingAssembly().GetName().Name}.xml");
            });
            
            IFileProvider fileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseCors(CORS_POLICY);

           // app.UseAuthentication();

            app.UseAuthorization();
            
            app.UseStaticFiles();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Digitization of Child Vaccine Card API");
            });
            
           UpdateDatabase(app);
        }
        
        /// <summary>
        ///     Updates the database with the latest migrations.
        /// </summary>
        /// <param name="app">A <see cref="IApplicationBuilder"/> representing the application builder.</param>
        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<VaccineDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}