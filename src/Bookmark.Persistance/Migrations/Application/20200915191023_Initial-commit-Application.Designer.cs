﻿// <auto-generated />
using System;
using Bookmark.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookmark.Persistance.Migrations.Application
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200915191023_Initial-commit-Application")]
    partial class InitialcommitApplication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookmark.Domain.Entities.CardFavorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("CardsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardsId");

                    b.ToTable("CardFavorite");
                });

            modelBuilder.Entity("Bookmark.Domain.Entities.Cards", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9cd60c95-6ee6-4a13-8549-c194841d4b21"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github Project Onion Architecture",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("25e5c8fb-d6ea-46c4-9c1f-3f7473726825"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github Project Clean Architecture",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("28e29545-2aeb-4e34-a5db-3ad5939c7257"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github account",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("99109f67-9d1d-43a4-992f-ff4a34ceae68"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github account",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("abd3542e-870f-4001-94f6-b1988ef34995"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github account",
                            Url = "https://github.com/Amitpnk"
                        });
                });

            modelBuilder.Entity("Bookmark.Domain.Entities.GroupShared", b =>
                {
                    b.Property<Guid>("CardsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardsId", "GroupsId");

                    b.HasIndex("GroupsId");

                    b.ToTable("GroupShared");

                    b.HasData(
                        new
                        {
                            CardsId = new Guid("9cd60c95-6ee6-4a13-8549-c194841d4b21"),
                            GroupsId = new Guid("7b3500ba-234a-49b5-a363-398023b37457"),
                            User = "1ecc6f29-9c64-446f-bce9-4f64e80e3789"
                        },
                        new
                        {
                            CardsId = new Guid("25e5c8fb-d6ea-46c4-9c1f-3f7473726825"),
                            GroupsId = new Guid("a0285e2b-1c68-499f-affe-61fb357e4dc4"),
                            User = "1ecc6f29-9c64-446f-bce9-4f64e80e3789"
                        });
                });

            modelBuilder.Entity("Bookmark.Domain.Entities.Groups", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7b3500ba-234a-49b5-a363-398023b37457"),
                            Description = "Github account",
                            IsActive = true,
                            Name = "Github account"
                        },
                        new
                        {
                            Id = new Guid("a0285e2b-1c68-499f-affe-61fb357e4dc4"),
                            Description = "c-sharp corner",
                            IsActive = true,
                            Name = "c-sharp corner"
                        },
                        new
                        {
                            Id = new Guid("9a1d4ac4-e22a-4f32-960f-470715c228fb"),
                            Description = "Code project",
                            IsActive = true,
                            Name = "Code project"
                        },
                        new
                        {
                            Id = new Guid("d53dbc44-fdc3-4c1f-9657-1d8ff9c06bca"),
                            Description = "Microsoft extension",
                            IsActive = true,
                            Name = "Microsoft extension"
                        });
                });

            modelBuilder.Entity("Bookmark.Domain.Entities.CardFavorite", b =>
                {
                    b.HasOne("Bookmark.Domain.Entities.Cards", "Cards")
                        .WithMany()
                        .HasForeignKey("CardsId");
                });

            modelBuilder.Entity("Bookmark.Domain.Entities.GroupShared", b =>
                {
                    b.HasOne("Bookmark.Domain.Entities.Cards", "Cards")
                        .WithMany()
                        .HasForeignKey("CardsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bookmark.Domain.Entities.Groups", "Groups")
                        .WithMany("GroupShareds")
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
