using BarberAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace BarberAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<HairCut> HairCuts { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Client>().HasKey(x => x.Id);
            mb.Entity<Client>().Property(x => x.Name).HasMaxLength(256).IsRequired();
            mb.Entity<Client>().Property(x => x.Gender).IsRequired();
            mb.Entity<HairCut>().HasKey(x => x.Id);
            mb.Entity<HairCut>().Property(x => x.Price).HasPrecision(10, 2).IsRequired();
            mb.Entity<HairCut>()
            .HasOne(h => h.Client)
            .WithMany()
            .HasForeignKey(h => h.ClientId)
            .OnDelete(DeleteBehavior.Cascade);
            mb.Entity<HairCut>().Property(x => x.ScheduledDate).IsRequired();
            base.OnModelCreating(mb);
        }
    }
}
