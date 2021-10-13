using CarRentalsAPI.BusinessLogic;
using CarRentalsAPI.ViewModels;
using CarRentalsAPI.ViewModels.Validators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRentalsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost]
        [Route("Rent")]
        public RentalResponse Rent([FromBody] RentalRequest request)
        {
            var validator = new RentalRequestValidator();
            var validationResult = validator.Validate(request);

            if (validationResult.IsValid)
            {
                return _rentalService.RequestRental(request);
            }
            else return new RentalResponse { Message = validationResult.ToString(), RentalNumber = string.Empty };
        }

        [HttpPost]
        [Route("Return")]
        public ReturnResponse Return([FromBody] ReturnRequest request)
        {
            var validator = new ReturnRequestValidator();
            var validationResult = validator.Validate(request);

            if (validationResult.IsValid)
            {
                return _rentalService.RequestReturn(request);
            }
            else return new ReturnResponse { Message = validationResult.ToString(), Price = 0 };
        }
    }
}
