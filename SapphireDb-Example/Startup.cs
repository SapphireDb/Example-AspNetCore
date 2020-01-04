using System.IO;
using FileContextCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using SapphireDb.Extensions;
using SapphireDb_Example.Data.Chat;

namespace SapphireDb_Example
{
    public class Startup
    {
        private readonly IHostEnvironment _environment;

        public Startup(IHostEnvironment environment)
        {
            _environment = environment;
        }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(b => b.AddConsole());
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            
            services.AddSapphireDb()
                .AddContext<ChatContext>(cfg =>
                    cfg.UseFileContextDatabase(location: Path.Combine(_environment.ContentRootPath, "Data", "Chat", "Store")));
                    // cfg.UseLoggerFactory(loggerFactory).UseNpgsql("User ID=realtime;Password=pw1234;Host=localhost;Port=5432;Database=demo;"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ChatContext context)
        {
            context.Database.EnsureCreated();
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(cfg => cfg.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseSapphireDb();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context => { await context.Response.WriteAsync("Hello World!"); });
            });
        }
    }
}