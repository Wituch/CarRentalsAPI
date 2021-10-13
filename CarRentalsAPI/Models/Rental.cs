using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.Models
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid ReservationNumber { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
        public int CarMilageAtRent { get; set; }
        public int CarMilageAtReturn { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Rented { get; set; }
        public DateTime Returned { get; set; }

        [NotMapped]
        public int NumberOfDays { get => (Returned - Rented).Days; }
        [NotMapped]
        public int NumberOfKilometers { get => CarMilageAtReturn - CarMilageAtRent; }
    }
}
