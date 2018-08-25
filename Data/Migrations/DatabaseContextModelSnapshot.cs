﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Boss", b =>
                {
                    b.Property<string>("BossId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("BossId");

                    b.HasIndex("BossId")
                        .IsUnique();

                    b.ToTable("Bosses");
                });

            modelBuilder.Entity("Data.Models.BossAlias", b =>
                {
                    b.Property<string>("AliasId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias");

                    b.Property<string>("BossId");

                    b.HasKey("AliasId");

                    b.HasIndex("AliasId")
                        .IsUnique();

                    b.HasIndex("BossId");

                    b.ToTable("BossAliases");
                });

            modelBuilder.Entity("Data.Models.DiscordUser", b =>
                {
                    b.Property<string>("DiscordUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DiscordUserId");

                    b.HasIndex("DiscordUserId")
                        .IsUnique();

                    b.ToTable("DiscordUsers");
                });

            modelBuilder.Entity("Data.Models.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<string>("BossId");

                    b.Property<string>("Name");

                    b.HasKey("RoleId");

                    b.HasIndex("BossId");

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Data.Models.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BossId");

                    b.Property<string>("HostDiscordUserId");

                    b.Property<int>("Limit");

                    b.Property<DateTime>("Time");

                    b.HasKey("SessionId");

                    b.HasIndex("BossId");

                    b.HasIndex("HostDiscordUserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Data.Models.BossAlias", b =>
                {
                    b.HasOne("Data.Models.Boss", "Boss")
                        .WithMany("Aliases")
                        .HasForeignKey("BossId");
                });

            modelBuilder.Entity("Data.Models.Role", b =>
                {
                    b.HasOne("Data.Models.Boss", "Boss")
                        .WithMany("Roles")
                        .HasForeignKey("BossId");
                });

            modelBuilder.Entity("Data.Models.Session", b =>
                {
                    b.HasOne("Data.Models.Boss", "Boss")
                        .WithMany()
                        .HasForeignKey("BossId");

                    b.HasOne("Data.Models.DiscordUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostDiscordUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
