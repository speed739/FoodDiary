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
    public class WelcomeW_LoginCommand : ICommand
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
            Login login = new Login();
            Methods Close = new Methods();
            Close.CloseMethod(EnumWindow.WelcomeW);
            login.ShowDialog();
        }
    }
}
