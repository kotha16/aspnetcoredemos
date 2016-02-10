﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.StaticFiles;

namespace demos
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseIISPlatformHandler();
            //app.UseStaticFiles();

            // only for dev
            //app.UseDeveloperExceptionPage();
            //app.UseRuntimeInfoPage();

            //production
            //app.UseExceptionHandler("/home/error");

            app.UseMvc(routes => 
                            routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}"));

            //app.UseFileServer();

            //// Enable all static file middleware (serving of static files, default files,
            //// and directory browsing) for the MyStaticFiles directory.
            app.UseFileServer(new FileServerOptions()
            {
                //FileProvider = new PhysicalFileProvider(@"D:\Source\WebApplication1\src\WebApplication1\MyStaticFiles"),
                //RequestPath = new PathString("/StaticFiles"),
                EnableDirectoryBrowsing = false
                
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            app.UseIISPlatformHandler();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
