using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.Models
{
    interface IEntity
    {
        int Id { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }
}
