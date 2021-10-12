using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsAPI.DAL
{
    public class RentalContext : DbContext
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
    }
}
