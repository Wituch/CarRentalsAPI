using CarRentalsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.DAL
{
    public interface IRentalContext
    {
        DbSet<Rental> Rentals { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Car> Cars { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Price> Prices { get; set; }
        DbSet<PriceRate> PriceRates { get; set; }

        DbSet<IEntity> Set<IEntity>() where IEntity : class;
        EntityEntry<IEntity> Entry(IEntity entity);
        void SaveChanges();
    }
}
