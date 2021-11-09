using Airport.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Data
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.41;Port=5432;Database=dbusertest;User Id=nata;Password=$5$BG)K$t!Ube}xk;");
        }

        public MyContext(){}

        public MyContext(DbContextOptions<MyContext> options)
           : base(options)
        {

        }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<Airplanes> Airplanes { get; set; }
        public virtual DbSet<Clients> Clients  { get; set; }
        public virtual DbSet<Flights> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //-----Clients-----
            builder.Entity<Clients>()
                .HasOne<Accounts>(ac => ac.Accounts)                
                .WithOne(c => c.Clients)
                .HasForeignKey<Clients>(c => c.AccountsId);

            builder.Entity<Clients>()
               .HasOne<Flights>(fl=>fl.Flights)
               .WithMany(c=>c.Clients)
               .HasForeignKey(c => c.FlightsId);

            builder.Entity<Clients>().Property(u => u.Email)
                                     .IsRequired()
                                     .HasMaxLength(100);
            builder.Entity<Clients>().Property(u => u.Name)
                                    .IsRequired()
                                    .HasMaxLength(100);
            builder.Entity<Clients>().Property(u => u.Gender)
                                    .IsRequired()
                                    .HasMaxLength(20);

            //------Accounts-----
            builder.Entity<Accounts>().Property(u => u.Login)
                                     .IsRequired()
                                     .HasMaxLength(100);
            builder.Entity<Accounts>().Property(u => u.Password)
                                     .IsRequired()
                                     .HasMaxLength(100);

            //-----Airplanes-----
            builder.Entity<Airplanes>()
                .HasOne<Flights>(f => f.Flights)
                .WithMany(a => a.Airplanes)
                .HasForeignKey(fl => fl.FlightsId);

            builder.Entity<Airplanes>().Property(u => u.Type)
                                       .IsRequired()
                                       .HasMaxLength(50);
            builder.Entity<Airplanes>().Property(u => u.Model)
                                       .IsRequired()
                                       .HasMaxLength(50);
            builder.Entity<Airplanes>().Property(u => u.Country)
                                       .IsRequired()
                                       .HasMaxLength(50);

            //-----Flights-----
            builder.Entity<Flights>().Property(u => u.ArrivCity)
                                     .IsRequired()
                                     .HasMaxLength(50);
            builder.Entity<Flights>().Property(u => u.DepartCity)
                                   .IsRequired()
                                   .HasMaxLength(50);
            
                                    
                                   
        }
    }
}
