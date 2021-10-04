using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabAssitantApi.Models;
using LabAssitantApi.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LabAssitantApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                 builder.SetIsOriginAllowed(_ => true)
                 .AllowAnyMethod().AllowAnyHeader().AllowCredentials());
            });
            services.AddScoped<IEmpData, EmpData>();
            services.AddDbContext<LabAssitantDBContext>(options => options.UseSqlServer("Server=LENOVO\\SQLEXPRESS;Database=LabAssitantDB;User ID=sa;Password=12345;"));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapControllers();
            });
        }
    }
}
