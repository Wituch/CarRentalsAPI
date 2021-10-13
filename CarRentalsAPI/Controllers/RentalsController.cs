using CarRentalsAPI.BusinessLogic;
using CarRentalsAPI.ViewModels;
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
            return _rentalService.RequestRental(request);
        }

        [HttpPost]
        [Route("Return")]
        public ReturnResponse Return([FromBody] ReturnRequest request)
        {
            return _rentalService.RequestReturn(request);
        }
    }
}
