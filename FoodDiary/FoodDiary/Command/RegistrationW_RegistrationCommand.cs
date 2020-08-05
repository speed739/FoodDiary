using FoodDiary.Model;
using FoodDiary.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FoodDiary.Command
{
    class RegistrationW_RegistrationCommand : ICommand
    {
        readonly RegistrationValidation Validation = new RegistrationValidation();
        readonly SqlQueries Query = new SqlQueries();

        public bool CanExecute(object parameter)
        {
            if (parameter != null && parameter is RegistrationModel)
            {
                var param = parameter as RegistrationModel;
                param.Errors = string.Join("\n", Validation.Validate(param).Errors);

                if (Validation.Validate(param).IsValid)
                {
                    Calculate(parameter);
                    return true;
                }
                return false;
            }
            return false;
        }
        public void Execute(object parameter)
        {
            var user = parameter as RegistrationModel;
            if (Check_login(user.Username))
            {
                Create(parameter);
                MessageBox.Show("Account has been created", "FoodDiary", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
        private void Create(object parameter)
        {
            var model = parameter as RegistrationModel;
            UserModel user = new UserModel(model);
            Query.CreateUser(user);
        }

        private bool Check_login(string username)
        {
            if (Query.CheckUser(username) > 0)
            {
                MessageBox.Show("Username is taken, please change it ", "FoodDiary", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }
            return true;
        }

        private void Calculate(object parameter)
        {
            var param = parameter as RegistrationModel;
            var height = param.Height / 100;
            param.BMI = param.Weight / (height * height);

            if (param.Woman == true)
            {
                param.BMR = (655 + (9.6 * param.Weight) + (1.8 * param.Height) - (4.7 * param.Age)) * param.ActivL;
            }
            else
            {
                param.BMR = ((9.99 * param.Weight) + (6.25 * param.Height) - (4.92 * param.Age) + 5) * param.ActivL;
            }
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
