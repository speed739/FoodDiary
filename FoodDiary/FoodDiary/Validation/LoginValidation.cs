using FluentValidation;
using FoodDiary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDiary.Validation
{
    public class LoginValidation : AbstractValidator<LoginModel>
    {
        /*Utworzyć konstruktor a w nim zaimplementować szereg reguł walidacji*/
        public LoginValidation()
        {
            /*Określić CascadeMode, jest to tryb działania validacji np StopOnFirstFailure zatrzymuje validacje w chwili napotkania 1 niezgodności */
            CascadeMode = CascadeMode.StopOnFirstFailure;

            /*Implementacja zasad validacji dla kontrolki RuleFor*/
            RuleFor(x => x.Login)
                .NotEmpty()
                .WithMessage("Login can't be empty");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password can't be empty");
        }
    }
}
