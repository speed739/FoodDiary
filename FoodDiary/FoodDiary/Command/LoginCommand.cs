using FluentValidation.Validators;
using FoodDiary.Model;
using FoodDiary.Validation;
using FoodDiary.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FoodDiary.Command
{
    class LoginCommand : ICommand
    {
        public LoginValidation Validations = new LoginValidation();

        public bool CanExecute(object parameter)
        {
            if (parameter != null)
            {
                if (parameter is object && parameter is LoginModel)
                {
                    var param = parameter as LoginModel;
                    param.Errors = string.Join(" ", Validations.Validate(param).Errors);

                    if (Validations.Validate(param).IsValid)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public void Execute(object parameter)
        {
            var param = parameter as LoginModel;
            SqlQueries query = new SqlQueries();

            if (query.Login(param.Login, param.Password) > 0)
            {
                //Global_Methods.username = txt_Username.Text;
                UserWindow userwindow = new UserWindow(param.Login);
                Methods.CloseMethod(EnumWindow.LoginW);
                userwindow.ShowDialog();
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Wrong login or password", "FoodDiary", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                if (result != MessageBoxResult.OK)
                {
                    WelcomeWindow main = new WelcomeWindow();
                    Methods.CloseMethod(EnumWindow.LoginW);
                    main.ShowDialog();
                }
            }
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
