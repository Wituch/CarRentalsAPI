using CarRentalsAPI.DAL;
using CarRentalsAPI.Models;
using CarRentalsAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public ReturnResponse RequestReturn(ReturnRequest requestData)
        {
            throw new NotImplementedException();
        }
    }
}
