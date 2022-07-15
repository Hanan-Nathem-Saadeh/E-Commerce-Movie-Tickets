﻿// <auto-generated />
using System;
using E_Commerce_Movie_Tickets.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Commerce_Movie_Tickets.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220715213029_seedingData")]
    partial class seedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Bio 1",
                            FullName = "Liam Hemsworth",
                            profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Bio 2",
                            FullName = "Tom Cruise",
                            profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Bio 3",
                            FullName = "Brad Pitt",
                            profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/a3.jpg"
                        });
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Actor_Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("Actors_Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 3
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 1
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 3
                        });
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            Logo = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/1.jpg",
                            Name = "Cinema 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            Logo = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/2.jpg",
                            Name = "Cinema 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            Logo = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/3.jpg",
                            Name = "Cinema 3"
                        });
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CinemaId = 1,
                            Description = "Description 1",
                            EndDate = new DateTime(2022, 7, 11, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(4028),
                            ImageURL = "",
                            MovieCategory = 2,
                            Name = "Movie 1",
                            Price = 20.5,
                            ProducerId = 2,
                            StartDate = new DateTime(2022, 7, 6, 0, 30, 28, 630, DateTimeKind.Local).AddTicks(6970)
                        },
                        new
                        {
                            Id = 2,
                            CinemaId = 2,
                            Description = "Description 2",
                            EndDate = new DateTime(2022, 7, 23, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8054),
                            ImageURL = "",
                            MovieCategory = 3,
                            Name = "Movie 2",
                            Price = 30.0,
                            ProducerId = 1,
                            StartDate = new DateTime(2022, 7, 16, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8015)
                        },
                        new
                        {
                            Id = 3,
                            CinemaId = 3,
                            Description = "Description 3",
                            EndDate = new DateTime(2022, 8, 5, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8076),
                            ImageURL = "",
                            MovieCategory = 1,
                            Name = "Movie 3",
                            Price = 15.0,
                            ProducerId = 3,
                            StartDate = new DateTime(2022, 7, 19, 0, 30, 28, 652, DateTimeKind.Local).AddTicks(8069)
                        });
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "producer 1",
                            FullName = "Producer 1",
                            profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "producer 2",
                            FullName = "Producer 2",
                            profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "producer 3",
                            FullName = "Producer 3",
                            profilePictureURL = "https://faststorestorage.blob.core.windows.net/moviesprojectmvc/p1.jpg"
                        });
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Actor_Movie", b =>
                {
                    b.HasOne("E_Commerce_Movie_Tickets.Models.Actor", "Actor")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_Movie_Tickets.Models.Movie", "Movie")
                        .WithMany("Actors_Movies")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Movie", b =>
                {
                    b.HasOne("E_Commerce_Movie_Tickets.Models.Cinema", "Cinema")
                        .WithMany("Movies")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_Commerce_Movie_Tickets.Models.Producer", "Producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Actor", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Cinema", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Movie", b =>
                {
                    b.Navigation("Actors_Movies");
                });

            modelBuilder.Entity("E_Commerce_Movie_Tickets.Models.Producer", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}