using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using FoodDiary.Command;
using FoodDiary.View;

namespace FoodDiary.ViewModel
{
    public class WelcomeWindowViewModel
    {
        public ICommand ExitCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public ICommand RegistrationCommand { get; set; }
        public WelcomeWindowViewModel()
        {
            ExitCommand = new WelcomeW_ExitCommand();
            LoginCommand = new WelcomeW_LoginCommand();
            RegistrationCommand = new WelcomeW_RegistrationCommand();
        }
    }
}
