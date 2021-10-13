using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.ViewModels
{
    public class ReturnRequest
    {
        public string RentalNumber { get; set; }
        public DateTime Returned { get; set; }
        public int CarMileage { get; set; }
    }
}
