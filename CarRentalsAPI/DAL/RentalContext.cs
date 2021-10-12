using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CarRentalsAPI.DAL
{
    public class RentalContext : DbContext, IRentalContext
    {
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<PriceRate> PriceRates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarRentals");
        }

        public EntityEntry<IEntity> Entry(IEntity entity)
        {
            return base.Entry(entity);
        }

        public void SaveChanges()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime (1980, 1, 1),
                    Created = DateTime.Now, 
                    Modified = DateTime.Now
                },
                new Customer
                {
                    Id = 2,
                    FirstName = "George",
                    LastName = "Smith",
                    BirthDate = new DateTime(1965, 6, 6),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Customer
                {
                    Id = 3,
                    FirstName = "Wiliam",
                    LastName = "Strong",
                    BirthDate = new DateTime(1991, 7, 18),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                }
            );

            modelBuilder.Entity<PriceRate>().HasData(
                new PriceRate
                {
                    Id = 1,
                    Name = "BaseDayRental",
                    Rate = 80,
                    ValidFrom = new DateTime(2021, 1, 1),
                    ValidTo = new DateTime(2021, 12, 31),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new PriceRate
                {
                    Id = 2,
                    Name = "KilometerPrice",
                    Rate = 1,
                    ValidFrom = new DateTime(2021, 1, 1),
                    ValidTo = new DateTime(2021, 12, 31),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Compact",
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Category
                {
                    Id = 2,
                    Name = "Premium",
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Category
                {
                    Id = 3,
                    Name = "Minivan",
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                }
            );

            modelBuilder.Entity<Price>().HasData(
                new Price
                {
                    Id = 1,
                    Formula = "BaseDayRental * NumberOfDays",
                    CategoryId = 1,
                    ValidFrom = new DateTime(2021, 1, 1),
                    ValidTo = new DateTime(2021, 12, 31),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Price
                {
                    Id = 2,
                    Formula = "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers",
                    CategoryId = 2,
                    ValidFrom = new DateTime(2021, 1, 1),
                    ValidTo = new DateTime(2021, 12, 31),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Price
                {
                    Id = 3,
                    Formula = "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)",
                    CategoryId = 3,
                    ValidFrom = new DateTime(2021, 1, 1),
                    ValidTo = new DateTime(2021, 12, 31),
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                }
            );

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Brand = "Lancia",
                    Model = "Ypsilon",
                    EnginePower = 1.2,
                    ProductionDate = new DateTime(2015, 1, 1),
                    CategoryId = 1,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Car
                {
                    Id = 2,
                    Brand = "BMW",
                    Model = "320i",
                    EnginePower = 2.0,
                    ProductionDate = new DateTime(2011, 1, 1),
                    CategoryId = 2,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                },
                new Car
                {
                    Id = 3,
                    Brand = "Citroën",
                    Model = "C8",
                    EnginePower = 2.2,
                    ProductionDate = new DateTime(2002, 1, 1),
                    CategoryId = 3,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                }
            ); 
        }
    }
}
