using CarRentalsAPI.BusinessLogic;
using CarRentalsAPI.DAL;
using CarRentalsAPI.Models;
using CarRentalsAPI.ViewModels;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentalsAPI.Tests.Tests
{
    [TestFixture]
    public class RentalServiceTests
    {
        [Test]
        public void RentExistingCarAsNewCustomer()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>().AsQueryable<Rental>());

            var customerRepositoryMock = new Mock<IRepository<Customer>>();
            customerRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Customer, bool>>>()))
                .Returns(new List<Customer>().AsQueryable<Customer>());

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(1)).Returns(new Car());

            var rentalService = new RentalService(customerRepositoryMock.Object, carRepositoryMock.Object, null, null, null, rentalRepositoryMock.Object);

            var rentalRequest = new RentalRequest {FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1980, 1, 1), CarId = 1, CarMileage = 100000, Rented = new DateTime(2021, 10, 13)};
            var result = rentalService.RequestRental(rentalRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Rental created", result.Message);
            Assert.IsNotEmpty(result.RentalNumber);
        }

        [Test]
        public void RentExistingCarAsExistingCustomer()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>().AsQueryable<Rental>());

            var customerRepositoryMock = new Mock<IRepository<Customer>>();
            customerRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Customer, bool>>>()))
                .Returns(new List<Customer> { new Customer() }.AsQueryable<Customer>());

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(1)).Returns(new Car());

            var rentalService = new RentalService(customerRepositoryMock.Object, carRepositoryMock.Object, null, null, null, rentalRepositoryMock.Object);

            var rentalRequest = new RentalRequest { FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1980, 1, 1), CarId = 1, CarMileage = 100000, Rented = new DateTime(2021, 10, 13) };
            var result = rentalService.RequestRental(rentalRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Rental created", result.Message);
            Assert.IsNotEmpty(result.RentalNumber);
        }

        [Test]
        public void TryToRentOccupiedCarAsNewCustomer()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental> { new Rental()}.AsQueryable<Rental>());

            var customerRepositoryMock = new Mock<IRepository<Customer>>();
            customerRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Customer, bool>>>()))
                .Returns(new List<Customer>().AsQueryable<Customer>());

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(1)).Returns(new Car());

            var rentalService = new RentalService(customerRepositoryMock.Object, carRepositoryMock.Object, null, null, null, rentalRepositoryMock.Object);

            var rentalRequest = new RentalRequest { FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1980, 1, 1), CarId = 1, CarMileage = 100000, Rented = new DateTime(2021, 10, 13) };
            var result = rentalService.RequestRental(rentalRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Car already rented or not exists", result.Message);
        }

        [Test]
        public void TryToRentNotExistingCarAsNewCustomer()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>().AsQueryable<Rental>());

            var customerRepositoryMock = new Mock<IRepository<Customer>>();
            customerRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Customer, bool>>>()))
                .Returns(new List<Customer>().AsQueryable<Customer>());

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(1));

            var rentalService = new RentalService(customerRepositoryMock.Object, carRepositoryMock.Object, null, null, null, rentalRepositoryMock.Object);

            var rentalRequest = new RentalRequest { FirstName = "John", LastName = "Doe", BirthDate = new DateTime(1980, 1, 1), CarId = 1, CarMileage = 100000, Rented = new DateTime(2021, 10, 13) };
            var result = rentalService.RequestRental(rentalRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Car already rented or not exists", result.Message);
        }

        [Test]
        public void ReturnCarSuccesfuly()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>
                {
                    new Rental
                    {
                        Car = new Car {CategoryId = 1},
                        Rented = new DateTime(2021, 10, 13),
                        Returned = new DateTime(2021, 10, 15),
                        CarMileageAtRent = 100000
                    }

                }.AsQueryable<Rental>());

            var pricesRepositoryMock = new Mock<IRepository<Price>>();
            pricesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Price, bool>>>()))
                .Returns(new List<Price>
                {
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays",
                        CategoryId = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers",
                        CategoryId = 2,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)",
                        CategoryId = 3,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }
                }.AsQueryable<Price>());

            var priceRatesRepositoryMock = new Mock<IRepository<PriceRate>>();
            priceRatesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<PriceRate, bool>>>()))
                .Returns(new List<PriceRate> 
                {
                    new PriceRate
                    {
                        Name = "BaseDayRental",
                        Rate = 80,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new PriceRate
                    {
                        Name = "KilometerPrice",
                        Rate = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }

                }.AsQueryable<PriceRate>());

            var rentalService = new RentalService(null, null, null, pricesRepositoryMock.Object, priceRatesRepositoryMock.Object, rentalRepositoryMock.Object);

            var returnRequest = new ReturnRequest { RentalNumber = "107F299B-9C8A-4C76-83D0-3D4EBF3C0BBB",  CarMileage = 100100, Returned = new DateTime(2021, 10, 15) };
            var result = rentalService.RequestReturn(returnRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Rental returned successfuly", result.Message);
            Assert.AreEqual(160, result.Price);
        }

        [Test]
        public void TryReturnAlreadyFinializedRental()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>().AsQueryable<Rental>());

            var pricesRepositoryMock = new Mock<IRepository<Price>>();
            pricesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Price, bool>>>()))
                .Returns(new List<Price>
                {
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays",
                        CategoryId = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers",
                        CategoryId = 2,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)",
                        CategoryId = 3,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }
                }.AsQueryable<Price>());

            var priceRatesRepositoryMock = new Mock<IRepository<PriceRate>>();
            priceRatesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<PriceRate, bool>>>()))
                .Returns(new List<PriceRate>
                {
                    new PriceRate
                    {
                        Name = "BaseDayRental",
                        Rate = 80,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new PriceRate
                    {
                        Name = "KilometerPrice",
                        Rate = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }

                }.AsQueryable<PriceRate>());

            var rentalService = new RentalService(null, null, null, pricesRepositoryMock.Object, priceRatesRepositoryMock.Object, rentalRepositoryMock.Object);

            var returnRequest = new ReturnRequest { RentalNumber = "107F299B-9C8A-4C76-83D0-3D4EBF3C0BBB", CarMileage = 100100, Returned = new DateTime(2021, 10, 15) };
            var result = rentalService.RequestReturn(returnRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Rental for provided number not found or already finalized", result.Message);
        }

        [Test]
        public void TryReturnWithInvalidMileage()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>
                {
                    new Rental
                    {
                        Car = new Car {CategoryId = 1},
                        Rented = new DateTime(2021, 10, 13),
                        Returned = new DateTime(2021, 10, 15),
                        CarMileageAtRent = 100000
                    }

                }.AsQueryable<Rental>());

            var pricesRepositoryMock = new Mock<IRepository<Price>>();
            pricesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Price, bool>>>()))
                .Returns(new List<Price>
                {
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays",
                        CategoryId = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers",
                        CategoryId = 2,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)",
                        CategoryId = 3,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }
                }.AsQueryable<Price>());

            var priceRatesRepositoryMock = new Mock<IRepository<PriceRate>>();
            priceRatesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<PriceRate, bool>>>()))
                .Returns(new List<PriceRate>
                {
                    new PriceRate
                    {
                        Name = "BaseDayRental",
                        Rate = 80,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new PriceRate
                    {
                        Name = "KilometerPrice",
                        Rate = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }

                }.AsQueryable<PriceRate>());

            var rentalService = new RentalService(null, null, null, pricesRepositoryMock.Object, priceRatesRepositoryMock.Object, rentalRepositoryMock.Object);

            var returnRequest = new ReturnRequest { RentalNumber = "107F299B-9C8A-4C76-83D0-3D4EBF3C0BBB", CarMileage = 90000, Returned = new DateTime(2021, 10, 15) };
            var result = rentalService.RequestReturn(returnRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Car mileage at return cannot be lesser then at rental", result.Message);
        }

        [Test]
        public void TryReturnWithPricesMissingFromDB()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>
                {
                    new Rental
                    {
                        Car = new Car {CategoryId = 1},
                        Rented = new DateTime(2021, 10, 13),
                        Returned = new DateTime(2021, 10, 15),
                        CarMileageAtRent = 100000
                    }

                }.AsQueryable<Rental>());

            var pricesRepositoryMock = new Mock<IRepository<Price>>();
            pricesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Price, bool>>>()))
                .Returns(new List<Price>
                {
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays",
                        CategoryId = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.2 + KilometerPrice * NumberOfKilometers",
                        CategoryId = 2,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new Price
                    {
                        Formula = "BaseDayRental * NumberOfDays * 1.7 + (KilometerPrice * NumberOfKilometers * 1.5)",
                        CategoryId = 3,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }
                }.AsQueryable<Price>());

            var priceRatesRepositoryMock = new Mock<IRepository<PriceRate>>();
            priceRatesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<PriceRate, bool>>>()))
                .Returns(new List<PriceRate>().AsQueryable<PriceRate>());

            var rentalService = new RentalService(null, null, null, pricesRepositoryMock.Object, priceRatesRepositoryMock.Object, rentalRepositoryMock.Object);

            var returnRequest = new ReturnRequest { RentalNumber = "107F299B-9C8A-4C76-83D0-3D4EBF3C0BBB", CarMileage = 100100, Returned = new DateTime(2021, 10, 15) };
            var result = rentalService.RequestReturn(returnRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Cannot calculate rental price. Please check system configuration and try again", result.Message);
        }

        [Test]
        public void TryReturnWithFormulaMissingFromDB()
        {
            var rentalRepositoryMock = new Mock<IRepository<Rental>>();
            rentalRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Rental, bool>>>()))
                .Returns(new List<Rental>
                {
                    new Rental
                    {
                        Car = new Car {CategoryId = 1},
                        Rented = new DateTime(2021, 10, 13),
                        Returned = new DateTime(2021, 10, 15),
                        CarMileageAtRent = 100000
                    }

                }.AsQueryable<Rental>());

            var pricesRepositoryMock = new Mock<IRepository<Price>>();
            pricesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<Price, bool>>>()))
                .Returns(new List<Price>().AsQueryable<Price>());

            var priceRatesRepositoryMock = new Mock<IRepository<PriceRate>>();
            priceRatesRepositoryMock.Setup(m => m.Query(It.IsAny<Expression<Func<PriceRate, bool>>>()))
                .Returns(new List<PriceRate>
                {
                    new PriceRate
                    {
                        Name = "BaseDayRental",
                        Rate = 80,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    },
                    new PriceRate
                    {
                        Name = "KilometerPrice",
                        Rate = 1,
                        ValidFrom = new DateTime(2021, 1, 1),
                        ValidTo = new DateTime(2021, 12, 31)
                    }

                }.AsQueryable<PriceRate>());

            var rentalService = new RentalService(null, null, null, pricesRepositoryMock.Object, priceRatesRepositoryMock.Object, rentalRepositoryMock.Object);

            var returnRequest = new ReturnRequest { RentalNumber = "107F299B-9C8A-4C76-83D0-3D4EBF3C0BBB", CarMileage = 100100, Returned = new DateTime(2021, 10, 15) };
            var result = rentalService.RequestReturn(returnRequest);

            Assert.IsNotNull(result);
            Assert.AreEqual("Cannot calculate rental price. Please check system configuration and try again", result.Message);
        }
    }
}
