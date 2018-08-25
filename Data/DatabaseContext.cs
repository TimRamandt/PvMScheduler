using System;
using System.Collections.Generic;
using System.Text;
using Data.Core.Facade;
using Data.Core.Seeding;
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
        public DbSet<BossAlias> BossAliases { get; set; }

        public DatabaseContext() { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //key logic
            builder.Entity<DiscordUser>()
                 .HasIndex(u => u.DiscordUserId)
                 .IsUnique();

            builder.Entity<BossAlias>()
                 .HasIndex(ba => ba.AliasId)
                 .IsUnique();

            builder.Entity<Boss>()
                 .HasIndex(b => b.BossId)
                 .IsUnique();

            builder.Entity<Role>()
                 .HasIndex(r => r.RoleId)
                 .IsUnique();

            builder.Entity<BossAlias>()
                .HasOne(ba => ba.Boss)
                .WithMany(b => b.Aliases)
                .HasForeignKey(ba => ba.BossId);

            builder.Entity<Role>()
                .HasOne(r => r.Boss)
                .WithMany(b => b.Roles)
                .HasForeignKey(r => r.BossId);

            //TO DO: Do seeding here. But EF core is throwing obscure errors.
            //seeding is now where the database instance is created.
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TO DO: put this in a config file
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PvmScheduler;Trusted_Connection=True;")
                .EnableSensitiveDataLogging();
        }
    }
}
