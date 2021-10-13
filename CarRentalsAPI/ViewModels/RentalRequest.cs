using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.ViewModels
{
    public class RentalRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public int CarId { get; set; }
        public int CarMileage { get; set; }
        public DateTime Rented { get; set; }
    }
}
