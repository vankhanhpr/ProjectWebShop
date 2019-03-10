﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProjectWebShop.Interface.lineproduct;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Responsitory;
using WebApiMyShop.Data;
using WebApiMyShop.Interface;

namespace ProjectWebShop
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
            //services.AddDbContext<MyDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<MyDBContext>(options =>
            options.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images")));//image
            services.AddTransient<ILineProductResponsitory, LineProductResponsitory>();//prodcut
            services.AddTransient<IProductResponsitory, ProductResponsitory>();//prodcut
            services.AddTransient<IImageProductResponsitory, ImageProductResponsitory>();//imageproduct
            services.AddTransient<IEvaluateResponsitory, EvaluateResponsitory>();//evaluate
            //services.AddMvc();
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();//show image
            app.UseDefaultFiles();//show image
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //app.UseCors(options => options.WithOrigins("https://localhost:44328").AllowAnyMethod());

            app.UseCors(builder => builder
                                    .AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()
                                    .AllowCredentials());
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseAuthentication();//add token
            app.UseDeveloperExceptionPage();//filter user
            app.UseMvcWithDefaultRoute();///filter user


        }
    }
}
