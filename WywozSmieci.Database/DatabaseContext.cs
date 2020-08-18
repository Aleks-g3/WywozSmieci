using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WywozSmieci.Model;

namespace WywozSmieci.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Wywoz> Wywozs { get; set; }
        public DbSet<Rejon> Rejons { get; set; }

        private readonly string _databasePath;

        public DatabaseContext() { }

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;

            //Database.EnsureDeleted();
            if (Database.EnsureCreated())
            {
                
            }


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
