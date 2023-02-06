﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parviz.WebAPI.Data;

namespace Parviz.WebAPI.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230205112906_NewItemAdd")]
    partial class NewItemAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parviz.WebAPI.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedTime = new DateTime(2023, 2, 2, 15, 29, 5, 241, DateTimeKind.Local).AddTicks(4429),
                            ImagePath = "https://amazoncomp.az/wp-content/uploads/2021/02/879e1188ce55477baa8a6111c7a9e4bb.jpg",
                            Name = "Lenovo Ideapad",
                            Price = 1600m,
                            Stock = 15
                        },
                        new
                        {
                            Id = 2,
                            CreatedTime = new DateTime(2023, 2, 3, 15, 29, 5, 241, DateTimeKind.Local).AddTicks(8546),
                            ImagePath = "https://kontakt.az/wp-content/uploads/gallery-tum/TM-DG-SBP-1105-SM-1849_25d3acf64c924d9482b1916e696cad69_w_png.webp",
                            Name = "Xiaomi 12",
                            Price = 1100m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 3,
                            CreatedTime = new DateTime(2023, 1, 31, 15, 29, 5, 241, DateTimeKind.Local).AddTicks(8565),
                            ImagePath = "https://kontakt.az/wp-content/uploads/2021/08/New-Project-48.jpg",
                            Name = "Sony PlayStation 5",
                            Price = 1800m,
                            Stock = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}