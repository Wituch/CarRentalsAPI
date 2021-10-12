﻿// <auto-generated />
using System;
using CarRentalsAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRentalsAPI.Migrations
{
    [DbContext(typeof(RentalContext))]
    [Migration("20211012185801_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRentalsAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<double>("EnginePower")
                        .HasColumnType("float");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Formula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.PriceRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PriceRates");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CarMilageAtRent")
                        .HasColumnType("int");

                    b.Property<int>("CarMilageAtReturn")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Number")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Rented")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Returned")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Car", b =>
                {
                    b.HasOne("CarRentalsAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Price", b =>
                {
                    b.HasOne("CarRentalsAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Rental", b =>
                {
                    b.HasOne("CarRentalsAPI.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.HasOne("CarRentalsAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
