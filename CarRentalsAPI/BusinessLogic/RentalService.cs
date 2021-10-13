using CarRentalsAPI.DAL;
using CarRentalsAPI.Models;
using CarRentalsAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarRentalsAPI.BusinessLogic
{
    public class RentalService : IRentalService
    {
        private IRepository<Customer> _customersRepository;
        private IRepository<Car> _carsRepository;
        private IRepository<Category> _categoriesRepository;
        private IRepository<Price> _pricesRepository;
        private IRepository<PriceRate> _priceRatesRepository;
        private IRepository<Rental> _rentalsRepository;

        public RentalService(IRepository<Customer> customersRepository, IRepository<Car> carsRepository,
            IRepository<Category> categoriesRepository, IRepository<Price> pricesRepository, IRepository<PriceRate> priceRatesRepository,
            IRepository<Rental> rentalsRepository)
        {
            _customersRepository = customersRepository;
            _carsRepository = carsRepository;
            _categoriesRepository = categoriesRepository;
            _pricesRepository = pricesRepository;
            _priceRatesRepository = priceRatesRepository;
            _rentalsRepository = rentalsRepository;
        }

        public RentalResponse RequestRental(RentalRequest requestData)
        {
            var existingCustomer = _customersRepository.Query(c => c.FirstName == requestData.FirstName && c.LastName == requestData.LastName &&
            c.BirthDate == requestData.BirthDate).FirstOrDefault();

            if (existingCustomer == null)
            {
                existingCustomer = _customersRepository.Add(new Customer
                {
                    FirstName = requestData.FirstName,
                    LastName = requestData.LastName,
                    BirthDate = requestData.BirthDate,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                });
            }

            var isCarAvailable = !_rentalsRepository.Query(r => r.CarId == requestData.CarId && r.Returned == DateTime.MinValue).Any();

            if (isCarAvailable)
            {
                var rental = new Rental
                {
                    Customer = existingCustomer,
                    CarId = requestData.CarId,
                    CarMilageAtRent = requestData.CarMilage,
                    Number = Guid.NewGuid(),
                    Rented = requestData.Rented,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                };

                _rentalsRepository.Add(rental);

                return new RentalResponse { Message = "Rental created", RentalNumber = rental.Number.ToString()};
            }

            else
            {
                return new RentalResponse { Message = "Car already rented", RentalNumber = string.Empty };
            }
        }

        public ReturnResponse RequestReturn(ReturnRequest requestData)
        {
            var existingRental = _rentalsRepository.Query(r => r.Number == Guid.Parse(requestData.RentalNumber) && r.Returned == DateTime.MinValue)
                .Include(r => r.Car).FirstOrDefault();

            if (existingRental == null)
            {
                return new ReturnResponse { Message = "Rental for provided number not found or already finalized" };
            }

            existingRental.CarMilageAtReturn = requestData.CarMilage;
            existingRental.Returned = requestData.Returned;
            _rentalsRepository.Update(existingRental);

            var price = CalculatePrice(existingRental);

            return new ReturnResponse {Message = "Rental returned successfuly", Price = price };
        }

        private double CalculatePrice(Rental rental)
        {
            //TODO Implement logic
            return 100;
        }
    }
}
