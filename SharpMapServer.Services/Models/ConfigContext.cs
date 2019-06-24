using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpMapServer.Services.Models
{
    public class ConfigContext : DbContext
    {
        public DbSet<ServiceRecord> Services { get; set; }
        public DbSet<LayerRecord> Layers { get; set; }
        public ConfigContext(DbContextOptions<ConfigContext> options) : base(options)
        {
            bool ret = Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlite(@"Data Source=sqlite.db");
        }
    }
}
