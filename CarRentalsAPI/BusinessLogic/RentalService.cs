using CarRentalsAPI.DAL;
using CarRentalsAPI.Models;
using CarRentalsAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using System.Text;

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

            var isCarAvailable = _carsRepository.GetById(requestData.CarId) != null && !_rentalsRepository.Query(r => r.CarId == requestData.CarId && r.Returned == DateTime.MinValue).Any();

            if (isCarAvailable)
            {
                var rental = new Rental
                {
                    Customer = existingCustomer,
                    CarId = requestData.CarId,
                    CarMileageAtRent = requestData.CarMileage,
                    ReservationNumber = Guid.NewGuid(),
                    Rented = requestData.Rented,
                    Created = DateTime.Now,
                    Modified = DateTime.Now
                };

                _rentalsRepository.Add(rental);

                return new RentalResponse { Message = "Rental created", RentalNumber = rental.ReservationNumber.ToString()};
            }

            else
            {
                return new RentalResponse { Message = "Car already rented or not exists"};
            }
        }

        public ReturnResponse RequestReturn(ReturnRequest requestData)
        {
            var existingRental = _rentalsRepository.Query(r => r.ReservationNumber == Guid.Parse(requestData.RentalNumber) && r.Returned == DateTime.MinValue)
                .Include(r => r.Car).FirstOrDefault();

            if (existingRental == null)
            {
                return new ReturnResponse { Message = "Rental for provided number not found or already finalized" };
            }

            if (requestData.CarMileage < existingRental.CarMileageAtRent)
            {
                return new ReturnResponse { Message = "Car mileage at return cannot be lesser then at rental" };
            }

            existingRental.CarMileageAtReturn = requestData.CarMileage;
            existingRental.Returned = requestData.Returned;
            var price = CalculatePrice(existingRental);

            if (price == -1)
            {
                return new ReturnResponse { Message = "Cannot calculate rental price. Please check system configuration and try again" };
            }

            _rentalsRepository.Update(existingRental);
            return new ReturnResponse {Message = "Rental returned successfuly", Price = price };
        }

        private double CalculatePrice(Rental rental)
        {
            var priceFormula = _pricesRepository.Query(p => p.CategoryId == rental.Car.CategoryId
            && p.ValidFrom <= rental.Returned && p.ValidTo >= rental.Returned).FirstOrDefault()?.Formula ?? string.Empty;

            if (string.IsNullOrEmpty(priceFormula)) return -1;

            var formulaBuilder = new StringBuilder(priceFormula);

            var priceRates = _priceRatesRepository.Query(pr => pr.ValidFrom <= rental.Returned && pr.ValidTo >= rental.Returned).ToList();
            foreach (var priceRate in priceRates)
            {
                formulaBuilder.Replace(priceRate.Name, priceRate.Rate.ToString());
            }

            var properties = rental.GetType().GetProperties();
            foreach (var property in properties.Where(p => p.PropertyType == typeof(int) || p.PropertyType == typeof(double)))
            {
                var propertyValue = property.GetValue(rental, null)?.ToString() ?? string.Empty;
                formulaBuilder.Replace(property.Name, propertyValue);
            }

            double result;
            try
            {
                result = CSharpScript.EvaluateAsync<double>(formulaBuilder.ToString()).Result;
            }

            catch (Exception ex)
            {
                return - 1;
            }

            return result;
        }
    }
}
