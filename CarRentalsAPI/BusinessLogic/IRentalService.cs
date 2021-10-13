using CarRentalsAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.BusinessLogic
{
    public interface IRentalService
    {
        RentalResponse RequestRental(RentalRequest requestData);
        ReturnResponse RequestReturn(ReturnRequest requestData);
    }
}
