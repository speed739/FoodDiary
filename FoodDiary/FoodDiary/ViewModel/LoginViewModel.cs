using FoodDiary.Command;
using FoodDiary.Model;
using FoodDiary.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FoodDiary.View;
using System.Security;

namespace FoodDiary.ViewModel
{
    public class LoginViewModel
    {
        public LoginModel LoginModel { get; set; }
        public LoginValidation LoginValidation { get; set; }
        public ICommand LoginCommand { get; set; }
        public LoginViewModel()
        {
            LoginModel = new LoginModel();
            LoginValidation = new LoginValidation();
            LoginCommand = new LoginW_LoginCommand();
        }
    }
}
