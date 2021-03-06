﻿using FoodDiary.Enum;
using FoodDiary.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FoodDiary.Command
{
    public class WelcomeW_RegistrationCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Registration registration = new Registration();
            Methods Close = new Methods();
            Close.CloseMethod(EnumWindow.WelcomeW);
            registration.ShowDialog();
        }
    }
}
