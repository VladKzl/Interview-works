﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserStatistics.Repository;

#nullable disable

namespace UserStatistics.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220717135053_NewPropertyUpdate")]
    partial class NewPropertyUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UserStatistics.Entities.Models.Statistics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountSignIn")
                        .HasColumnType("int");

                    b.Property<int>("Persentage")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserStatistics");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0dbb3717-2247-4cba-bc15-7301a0db61ed"),
                            CountSignIn = 12,
                            Persentage = 0,
                            UserId = new Guid("46b8f8c0-c862-4eba-8aa5-00aaad88956f")
                        },
                        new
                        {
                            Id = new Guid("4cfa3be9-0092-4303-8eb3-9c8517e4fd12"),
                            CountSignIn = 8,
                            Persentage = 0,
                            UserId = new Guid("c9e65435-3d16-4dd1-a2be-a0e752accf3a")
                        },
                        new
                        {
                            Id = new Guid("952b6c51-3c62-4e6e-b37b-6d4d45c39207"),
                            CountSignIn = 2,
                            Persentage = 0,
                            UserId = new Guid("5746db32-ed0c-48a4-bae5-0df5783ea60e")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
