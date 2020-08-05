using FluentValidation;
using FoodDiary.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDiary.Validation
{
    public class RegistrationValidation : AbstractValidator<RegistrationModel>
    {
        public RegistrationValidation()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;


            RuleFor(x => x.Username)
                .NotEmpty()
                .WithMessage("     Warrning - Username min lenght - 5")
                .MinimumLength(5)
                .WithMessage("     Warrning - Username min lenght - 5");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("     Warrning - Password can't be empty");

            RuleFor(x => x.Weight)
                .NotEmpty()
                .WithMessage("     Warrning - Weight field can't be empty");

            RuleFor(x => x.Height)
                .NotEmpty()
                .WithMessage("     Warrning - Height field can't be empty");

            RuleFor(x => x.Age)
                .NotEmpty()
                .WithMessage("     Warrning - Age field can't be empty");
        }
    }
}
