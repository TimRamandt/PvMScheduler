using System;
using System.Collections.Generic;
using System.Text;
using Data.Core.Facade;
using Data.Facades;
using Data.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<DiscordUser> DiscordUsers { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public IDiscordUserFacade DiscordUserFacade;

        public DatabaseContext()
        {
            this.DiscordUserFacade = new DiscordUserFacade(this);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DiscordUser>()
                 .HasIndex(u => u.DiscordUserId)
                 .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TO DO: put this in a config file
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PvmScheduler;Trusted_Connection=True;");
        }
    }
}
