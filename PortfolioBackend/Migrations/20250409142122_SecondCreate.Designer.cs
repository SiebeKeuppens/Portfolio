﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortfolioBackend.Data;

#nullable disable

namespace PortfolioBackend.Migrations
{
    [DbContext(typeof(PortfolioDbContext))]
    [Migration("20250409142122_SecondCreate")]
    partial class SecondCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.15");

            modelBuilder.Entity("PortfolioBackend.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GitHubUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LiveDemoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TechnologiesUsed")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompletedDate = new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4490),
                            Description = "A personal portfolio website showcasing my development projects and skills",
                            GitHubUrl = "unkown",
                            ImageUrl = "/assets/images/portfolio.jpg",
                            IsFeatured = true,
                            LiveDemoUrl = "unknown",
                            TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                            Title = "Portfolio Website"
                        },
                        new
                        {
                            Id = 2,
                            CompletedDate = new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4540),
                            Description = "A personal portfolio website showcasing my development projects and skills",
                            GitHubUrl = "unkown",
                            ImageUrl = "/assets/images/portfolio.jpg",
                            IsFeatured = true,
                            LiveDemoUrl = "unknown",
                            TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                            Title = "Portfolio Website"
                        },
                        new
                        {
                            Id = 3,
                            CompletedDate = new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550),
                            Description = "A personal portfolio website showcasing my development projects and skills",
                            GitHubUrl = "unkown",
                            ImageUrl = "/assets/images/portfolio.jpg",
                            IsFeatured = true,
                            LiveDemoUrl = "unknown",
                            TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                            Title = "Portfolio Website"
                        },
                        new
                        {
                            Id = 4,
                            CompletedDate = new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550),
                            Description = "A personal portfolio website showcasing my development projects and skills",
                            GitHubUrl = "unkown",
                            ImageUrl = "/assets/images/portfolio.jpg",
                            IsFeatured = true,
                            LiveDemoUrl = "unknown",
                            TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                            Title = "Portfolio Website"
                        },
                        new
                        {
                            Id = 5,
                            CompletedDate = new DateTime(2025, 4, 9, 16, 21, 22, 556, DateTimeKind.Local).AddTicks(4550),
                            Description = "A personal portfolio website showcasing my development projects and skills",
                            GitHubUrl = "unkown",
                            ImageUrl = "/assets/images/portfolio.jpg",
                            IsFeatured = true,
                            LiveDemoUrl = "unknown",
                            TechnologiesUsed = "Angular, .NET Core, Entity Framework Core, SQLite",
                            Title = "Portfolio Website"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
