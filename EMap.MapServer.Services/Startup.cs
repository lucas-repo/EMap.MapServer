using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EMap.MapServer.Services.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Http.Features;

namespace EMap.MapServer.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Configuration = configuration;
        }
        private static Assembly GetAssembly(string fileName)
        {
            Assembly assembly = null;
            if (File.Exists(fileName))
            {
                assembly = Assembly.LoadFrom(fileName);
            }
            return assembly;
        }
        private Assembly GetAssembly(string directory, string assemblyName)
        {
            Assembly assembly = null;
            string path = Path.Combine(directory, assemblyName);
            if (File.Exists(path))
            {
                assembly = Assembly.LoadFrom(path);
            }
            if (assembly == null)
            {
                string[] directories  = Directory.GetDirectories(directory);
                foreach (var item in directories)
                {
                    assembly = GetAssembly(item,  assemblyName);
                    if (assembly != null)
                    {
                        break;
                    }
                }
            }
            return assembly;
        }
        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string privatePath = "Dependencies";
            Assembly assembly = null;
            string[] directoryNames = privatePath.Split(';');
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string extension = Path.GetExtension(args.RequestingAssembly.CodeBase);
            string[] arry = args.Name.Split(',');
            string name = arry[0];
            string assemblyName = $"{name}{extension}";
            foreach (var directoryName in directoryNames)
            {
                string directory = Path.Combine(baseDirectory, directoryName);
                assembly = GetAssembly(directory, assemblyName);
                if (assembly != null)
                {
                    break;
                }
            }
            return assembly;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var connection = Configuration.GetConnectionString("ConfigContext");
            services.AddDbContext<ConfigContext>(options => options.UseSqlite(connection));
            services.Configure<FormOptions>(options =>
            {
                options.ValueLengthLimit = int.MaxValue;
                options.MultipartBodyLengthLimit = int.MaxValue; // In case of multipart
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Services}/{action=Index}/{id?}");
            });
        }
    }
}
