using FoodDiary.Command;
using FoodDiary.Model;
using FoodDiary.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodDiary.ViewModel
{
    public class RegistrationViewModel
    {
        public RegistrationModel RegistrationModel { get; set; }
        public RegistrationValidation RegistrationValidation { get; set; }
        public ICommand RegistrationCommand { get; set; }

        public RegistrationViewModel()
        {
            RegistrationModel = new RegistrationModel();
            RegistrationValidation = new RegistrationValidation();
            RegistrationCommand = new RegistrationW_RegistrationCommand();
        }
    }
}
