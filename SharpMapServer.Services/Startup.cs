using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharpMapServer.Services.Models;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Reflection;
using System.IO;

namespace SharpMapServer.Services
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
        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly assembly = null;

            var privatePath = Configuration.GetValue<string>("privatePath");
            string[] directoryNames = privatePath.Split(';');
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string extension = Path.GetExtension(args.RequestingAssembly.CodeBase);
            string directory = null;
            string[] arry = args.Name.Split(',');
            string name = arry[0];
            string path = null;
            foreach (var directoryName in directoryNames)
            {
                directory = Path.Combine(baseDirectory, directoryName);
                path = Path.Combine(directory, $"{name}{extension}");
                assembly = GetAssembly(path);
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
            app.UseMvc();
        }
    }
}
