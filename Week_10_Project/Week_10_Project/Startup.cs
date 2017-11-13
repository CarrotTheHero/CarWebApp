using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Week_10_Project.Repositories;
using Week_10_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace Week_10_Project
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<CarContext>(options =>options.UseNpgsql(@"User ID=acpmzmokcvfuzv;Password=306d85b37aa92ec93bc22cf53c75670b9ad755b53eb64db0f56235459e6d8f46;Host=ec2-54-247-120-234.eu-west-1.compute.amazonaws.com;Port=5432;Database=dd8k8uh04qdjqp;Pooling=true;sslmode=Require;Trust Server Certificate=true;Timeout=1000;"));
            services.AddScoped<CarRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
