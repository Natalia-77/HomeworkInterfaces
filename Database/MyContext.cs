using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MyContext : DbContext
    {
        public DbSet<Artist> Artists{ get; set; }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<Tracks> Tracks { get; set; }
        public DbSet<Playlists> Playlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.41;Port=5432;Database=dbusertest;User Id=nata;Password=$5$BG)K$t!Ube}xk;");
        }


    }
}
