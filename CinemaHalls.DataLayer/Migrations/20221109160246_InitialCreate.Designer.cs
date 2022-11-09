﻿// <auto-generated />
using System;
using CinemaHalls.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CinemaHalls.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221109160246_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Hall", b =>
                {
                    b.Property<byte>("Number")
                        .HasColumnType("tinyint");

                    b.HasKey("Number");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cast")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedTitle")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Screening", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("HallId")
                        .HasColumnType("tinyint");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("HallId")
                        .HasColumnType("tinyint");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Showing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Showings");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Genre", b =>
                {
                    b.HasOne("CinemaHalls.DataLayer.Entities.Movie", null)
                        .WithMany("Genres")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Screening", b =>
                {
                    b.HasOne("CinemaHalls.DataLayer.Entities.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaHalls.DataLayer.Entities.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Seat", b =>
                {
                    b.HasOne("CinemaHalls.DataLayer.Entities.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Showing", b =>
                {
                    b.HasOne("CinemaHalls.DataLayer.Entities.Movie", null)
                        .WithMany("Showings")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Hall", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("CinemaHalls.DataLayer.Entities.Movie", b =>
                {
                    b.Navigation("Genres");

                    b.Navigation("Showings");
                });
#pragma warning restore 612, 618
        }
    }
}
