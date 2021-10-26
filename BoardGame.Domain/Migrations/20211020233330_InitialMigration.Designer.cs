﻿// <auto-generated />
using System;
using API.Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BoardGame.Domain.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211020233330_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BoardGame.Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("JoinedSessionAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int?>("SessionId")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("SessionId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Block", b =>
                {
                    b.Property<int>("BlockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BlockOrder")
                        .HasColumnType("integer");

                    b.Property<int>("BlockPositionX")
                        .HasColumnType("integer");

                    b.Property<int>("BlockPositionY")
                        .HasColumnType("integer");

                    b.Property<int>("BlockTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("MonsterId")
                        .HasColumnType("integer");

                    b.Property<int>("SessionId")
                        .HasColumnType("integer");

                    b.HasKey("BlockId");

                    b.HasIndex("BlockTypeId");

                    b.HasIndex("MonsterId");

                    b.HasIndex("SessionId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.BlockType", b =>
                {
                    b.Property<int>("BlockTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BlockCategory")
                        .HasColumnType("integer");

                    b.Property<bool>("ExitDown")
                        .HasColumnType("boolean");

                    b.Property<bool>("ExitLeft")
                        .HasColumnType("boolean");

                    b.Property<bool>("ExitRight")
                        .HasColumnType("boolean");

                    b.Property<bool>("ExitTop")
                        .HasColumnType("boolean");

                    b.Property<string>("ImageName")
                        .HasColumnType("text");

                    b.HasKey("BlockTypeId");

                    b.ToTable("BlockTypes");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.ChatMessage", b =>
                {
                    b.Property<int>("ChatMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("Sender")
                        .HasColumnType("text");

                    b.Property<int>("SessionId")
                        .HasColumnType("integer");

                    b.HasKey("ChatMessageId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Hero", b =>
                {
                    b.Property<int>("HeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AppUserId")
                        .HasColumnType("integer");

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<int>("BlockId")
                        .HasColumnType("integer");

                    b.Property<int>("DmgMax")
                        .HasColumnType("integer");

                    b.Property<int>("DmgMin")
                        .HasColumnType("integer");

                    b.Property<int>("Experience")
                        .HasColumnType("integer");

                    b.Property<int>("ExperienceCap")
                        .HasColumnType("integer");

                    b.Property<string>("HeroName")
                        .HasColumnType("text");

                    b.Property<int>("HeroType")
                        .HasColumnType("integer");

                    b.Property<int>("HeroTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("Lives")
                        .HasColumnType("integer");

                    b.Property<int>("LivesCap")
                        .HasColumnType("integer");

                    b.Property<int>("SkillPoints")
                        .HasColumnType("integer");

                    b.HasKey("HeroId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BlockId");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BlockId")
                        .HasColumnType("integer");

                    b.Property<int>("HeroId")
                        .HasColumnType("integer");

                    b.Property<string>("ItemName")
                        .HasColumnType("text");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("integer");

                    b.HasKey("ItemId");

                    b.HasIndex("BlockId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.ItemType", b =>
                {
                    b.Property<int>("ItemTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.HasKey("ItemTypeId");

                    b.ToTable("ItemTypes");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Monster", b =>
                {
                    b.Property<int>("MonsterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Armor")
                        .HasColumnType("integer");

                    b.Property<int>("DmgMax")
                        .HasColumnType("integer");

                    b.Property<int>("DmgMin")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<int>("Life")
                        .HasColumnType("integer");

                    b.Property<string>("MonsterName")
                        .HasColumnType("text");

                    b.Property<int>("MonsterTypeId")
                        .HasColumnType("integer");

                    b.HasKey("MonsterId");

                    b.HasIndex("MonsterTypeId");

                    b.ToTable("Monsters");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.MonsterType", b =>
                {
                    b.Property<int>("MonsterTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.HasKey("MonsterTypeId");

                    b.ToTable("MonsterTypes");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Session", b =>
                {
                    b.Property<int>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CenterBlockPosition")
                        .HasColumnType("integer");

                    b.Property<int?>("CurrentPlayerId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastTurnChange")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PlanSize")
                        .HasColumnType("integer");

                    b.Property<string>("SessionName")
                        .HasColumnType("text");

                    b.Property<string>("SessionPassword")
                        .HasColumnType("text");

                    b.Property<int>("SessionType")
                        .HasColumnType("integer");

                    b.HasKey("SessionId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.AppUser", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.Session", "Session")
                        .WithMany()
                        .HasForeignKey("SessionId");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.AppUserRole", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGame.Domain.Entities.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Block", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.BlockType", "BlockType")
                        .WithMany()
                        .HasForeignKey("BlockTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGame.Domain.Entities.Monster", "Monster")
                        .WithMany()
                        .HasForeignKey("MonsterId");

                    b.HasOne("BoardGame.Domain.Entities.Session", null)
                        .WithMany("Blocks")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlockType");

                    b.Navigation("Monster");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Hero", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardGame.Domain.Entities.Block", null)
                        .WithMany("Heroes")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Item", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.Block", null)
                        .WithMany("Items")
                        .HasForeignKey("BlockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Monster", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.MonsterType", "MonsterType")
                        .WithMany()
                        .HasForeignKey("MonsterTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MonsterType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("BoardGame.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Block", b =>
                {
                    b.Navigation("Heroes");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("BoardGame.Domain.Entities.Session", b =>
                {
                    b.Navigation("Blocks");
                });
#pragma warning restore 612, 618
        }
    }
}