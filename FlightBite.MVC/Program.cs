using FlightBite.Data;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using FlightBite.Data.Services;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace FlightBite.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContextPool<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IEnquiryMaster, EnquiryMasterRepository>();
            builder.Services.AddScoped<IEnquiryPlatform, EnquiryPlatformRepository>();
            builder.Services.AddScoped<IUserType, UserTypeRepository>();
            builder.Services.AddScoped<IEnquiryStatus, EnquiryStatusRepository>();

            builder.Services.AddScoped<ILogRequestResponse, LogRequestResponse<DatabaseContext>>();
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            /*app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );*/

            app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area=SuperAdmin}/{controller=Home}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            
            app.Run();
        }
    }
}