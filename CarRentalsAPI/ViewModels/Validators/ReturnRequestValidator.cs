using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalsAPI.ViewModels.Validators
{
    public class ReturnRequestValidator : AbstractValidator<ReturnRequest>
    {
        public ReturnRequestValidator()
        {
            RuleFor(x => x.RentalNumber).NotEmpty().WithMessage("Specify reservation number").Must(BeValidGUID).WithMessage("Specify valid reservation number");
            RuleFor(x => x.CarMileage).NotEmpty().WithMessage("Specify car mileage").GreaterThan(0).WithMessage("Specify valid car mileage");
            RuleFor(x => x.Returned).NotEmpty().WithMessage("Specify a return date");
        }

        private bool BeValidGUID(string guid)
        {
            return Guid.TryParse(guid, out var guidOutput);
        }
    }
}
