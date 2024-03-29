﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Data.Abstract;
using CourseApp.Data.Concrete;
using CourseApp.Data.Concrete.EfCore;
using CourseApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace CourseApp
{
    public class Startup
    {
        public IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefCon"));
                options.EnableSensitiveDataLogging(true);
            });
            services.AddTransient<ICourseRepository, EfCourseRepository>();
            services.AddTransient<IInstructorRepository, EfInstructorRepository>();
            services.AddTransient<IGenericRepository<Contact>, GenericRepository<Contact>>();
            services.AddTransient<IGenericRepository<Address>, GenericRepository<Address>>();             
        }
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DataContext dataContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed(dataContext);
            }
            app.UseDeveloperExceptionPage();//Hata sayfalarını görmek için gerekli olan kod.
            app.UseStatusCodePages();//Sayfanın durumunu beyan eden, hata ya da durum sayfalarını göstermesi için kullandığımız kod.
            app.UseStaticFiles(); //Varsayılan olarak www.root dosyasını göstererek bu dosyanın içindeki css, js ve lib dosyalarına ulaşmasını sağlar.
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"node_modules")),
                RequestPath = new PathString("/vendor")
            });
        }
    }
}
