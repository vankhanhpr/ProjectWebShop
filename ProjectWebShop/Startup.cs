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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProjectWebShop.Auth;
using ProjectWebShop.Interface.compalin;
using ProjectWebShop.Interface.invoice;
using ProjectWebShop.Interface.lineproduct;
using ProjectWebShop.Interface.product;
using ProjectWebShop.Interface.register;
using ProjectWebShop.Interface.unit;
using ProjectWebShop.Interface.user;
using ProjectWebShop.Responsitory;
using ProjectWebShop.Responsitory.complain;
using ProjectWebShop.Responsitory.discount;
using ProjectWebShop.Responsitory.invoice;
using ProjectWebShop.Responsitory.register;
using ProjectWebShop.Responsitory.unit;
using ProjectWebShop.WebSockets;
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
            services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/user")));//image user

            services.AddTransient<ILineProductResponsitory, LineProductResponsitory>();//prodcut
            services.AddTransient<IProductResponsitory, ProductResponsitory>();//prodcut
            services.AddTransient<IImageProductResponsitory, ImageProductResponsitory>();//imageproduct
            services.AddTransient<IEvaluateResponsitory, EvaluateResponsitory>();//evaluate
            services.AddScoped<IUserResponsitory , UserResponsitory>();//login
            services.AddScoped<IAuthService, AuthServiceImpl>();

            services.AddTransient<IProvinceResponsitory, ProvinceResponsitory>();
            services.AddTransient<IDistrictResponsitory, DistrictResponsitory>();
            services.AddTransient<IInvoiceResponsitory, InvoiceResponsitory>();
            services.AddTransient<IDescribeResponsitory, DescribeResponsitory>();
            services.AddTransient<IDiscountResponsitory, DiscountResponsitory>();
            services.AddTransient<IRegisterResponsitory, RegisterResponsitory>();
            services.AddTransient<IComplainResponsitory, ComplainResponsitory>();

            services.AddCors();
            services.AddIdentity<ApplicationUser, IdentityRole>()
               .AddEntityFrameworkStores<ApplicationDbContext>()
               .AddDefaultTokenProviders();//add token for user
            //add token
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // có validate Server tạo JWT không ?
                    ValidateAudience = true,
                    ValidateLifetime = true, //có validate expire time hay không ?
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            services.AddWebSocketManager();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseStaticFiles();//show image
            app.UseDefaultFiles();//show image
            app.UseWebSockets();
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
            var wsOptions = new WebSocketOptions()//websocket
            {
                KeepAliveInterval = TimeSpan.FromSeconds(60),
                ReceiveBufferSize = 4 * 1024
            };
            app.UseWebSockets(wsOptions);
            //app.MapWebSocketManager("/admin",serviceProvider.GetService<ChatRoomHandler>());
            app.MapWebSocketManager("/admin",serviceProvider.GetService<ObjectHandler>());
        }
    }
}
