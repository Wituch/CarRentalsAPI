// <auto-generated />
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
    [Migration("20211014084724_FixMileageColumnsTypos")]
    partial class FixMileageColumnsTypos
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

                    b.Property<int>("CategoryId")
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Lancia",
                            CategoryId = 1,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(1161),
                            EnginePower = 1.2,
                            Model = "Ypsilon",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(1616),
                            ProductionDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Brand = "BMW",
                            CategoryId = 2,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2154),
                            EnginePower = 2.0,
                            Model = "320i",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2216),
                            ProductionDate = new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Citroën",
                            CategoryId = 3,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2235),
                            EnginePower = 2.2000000000000002,
                            Model = "C8",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 733, DateTimeKind.Local).AddTicks(2240),
                            ProductionDate = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(2878),
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3366),
                            Name = "Compact"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3870),
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3902),
                            Name = "Premium"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3922),
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(3929),
                            Name = "Minivan"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 726, DateTimeKind.Local).AddTicks(5862),
                            FirstName = "John",
                            LastName = "Doe",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(923)
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1965, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1644),
                            FirstName = "George",
                            LastName = "Smith",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1677)
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1991, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1697),
                            FirstName = "Wiliam",
                            LastName = "Strong",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 730, DateTimeKind.Local).AddTicks(1702)
                        });
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(6848),
                            Formula = "BaseDayRental * NumberOfDays",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7303),
                            ValidFrom = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ValidTo = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7858),
                            Formula = "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7889),
                            ValidFrom = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ValidTo = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7907),
                            Formula = "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)",
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(7914),
                            ValidFrom = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ValidTo = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(72),
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(551),
                            Name = "BaseDayRental",
                            Rate = 80.0,
                            ValidFrom = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ValidTo = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(1115),
                            Modified = new DateTime(2021, 10, 14, 10, 47, 23, 732, DateTimeKind.Local).AddTicks(1149),
                            Name = "KilometerPrice",
                            Rate = 1.0,
                            ValidFrom = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ValidTo = new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CarMileageAtRent")
                        .HasColumnType("int");

                    b.Property<int>("CarMileageAtReturn")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Rented")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ReservationNumber")
                        .HasColumnType("uniqueidentifier");

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
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Price", b =>
                {
                    b.HasOne("CarRentalsAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CarRentalsAPI.Models.Rental", b =>
                {
                    b.HasOne("CarRentalsAPI.Models.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRentalsAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
