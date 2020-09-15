﻿// <auto-generated />
using System;
using Bookmark.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookmark.Persistance.Migrations.Application
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("acf5ad7b-5641-41d8-a832-aa31dae1f078"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github Project Onion Architecture",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("0bee4cae-fdc7-43ba-aa15-687c4c0588fe"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github Project Clean Architecture",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("f2e60eac-de02-4d91-8b99-f85768b1f1ec"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github account",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("5a2508d8-6f0a-485e-8c4f-604d915d467f"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github account",
                            Url = "https://github.com/Amitpnk"
                        },
                        new
                        {
                            Id = new Guid("c65b47ac-3ce7-4cbf-b398-946e681f2470"),
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Github account",
                            DisplayIcon = "Bookmark",
                            Name = "Github account",
                            Url = "https://github.com/Amitpnk"
                        });
                });

            modelBuilder.Entity("Bookmark.Domain.Entities.GroupShared", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("CardsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("CardsId");

                    b.HasIndex("GroupsId");

                    b.ToTable("GroupShared");
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
                        .HasForeignKey("CardsId");

                    b.HasOne("Bookmark.Domain.Entities.Groups", "Groups")
                        .WithMany()
                        .HasForeignKey("GroupsId");
                });
#pragma warning restore 612, 618
        }
    }
}
