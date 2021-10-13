using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.ViewModels.Validators
{
    public class RentalRequestValidator : AbstractValidator<RentalRequest>
    {
        public RentalRequestValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Specify a first name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Specify a second name");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Specify a birth date").Must(BeOver18).WithMessage("Driver must be over 18 to rent a car");
            RuleFor(x => x.CarId).NotEmpty().WithMessage("Specify car id").GreaterThan(0).WithMessage("Specify valid car id");
            RuleFor(x => x.CarMileage).NotEmpty().WithMessage("Specify car mileage").GreaterThan(0).WithMessage("Specify valid car mileage");
            RuleFor(x => x.Rented).NotEmpty().WithMessage("Specify a rental date");
        }

        private bool BeOver18(DateTime birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}
