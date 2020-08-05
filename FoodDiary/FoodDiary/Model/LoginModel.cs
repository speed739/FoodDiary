using FoodDiary.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoodDiary.Model
{
    public class LoginModel : INotifyPropertyChanged
    {
        private string _login, _password, _errors;
        public string Login
        {
            get => _login;
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                }
            }
        }
        public string Errors
        {
            get => _errors;
            set
            {
                if (_errors != value)
                {
                    _errors = value;
                    OnPropertyChanged();
                }
            }
        }
       private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
