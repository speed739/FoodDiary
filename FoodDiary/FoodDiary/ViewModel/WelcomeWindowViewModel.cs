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
        public ICommand SignUpCommand { get; set; }
        public ICommand RegistrationCommand { get; set; }
        public WelcomeWindowViewModel()
        {
            ExitCommand = new WelcomeWindowExitCommand();
            SignUpCommand = new WelcomeWindowSignUpCommand();
            RegistrationCommand = new WelcomeWindowRegistrationCommand();
        }
    }
}
