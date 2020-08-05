using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodDiary.Model
{
    public class RegistrationModel : INotifyPropertyChanged
    {
        private string _username, _password, _errors;
        private bool _activityLevelL = true, _activityLevelM, _activityLevelH, _man = true, _woman;
        private double _height, _weight, _bmi, _bmr, _age, _actv_l = 1.2;


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
        public double ActivL
        {
            get => _actv_l;
            set
            {
                if (_actv_l != value)
                {
                    _actv_l = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool Man
        {
            get => _man;
            set
            {
                switch (value)
                {
                    case true:
                        {
                            _man = true;
                            if (_woman)
                            {
                                Woman = false;
                            }
                            break;
                        }
                    case false:
                        {
                            if (!_woman)
                            {
                                _man = true;
                            }
                            else { _man = false; }
                            break;
                        }
                }
                OnPropertyChanged();
            }
        }
        public bool Woman
        {
            get => _woman;
            set
            {
                switch (value)
                {
                    case true:
                        {
                            _woman = true;
                            if (_man)
                            {
                                Man = false;
                            }
                            break;
                        }
                    case false:
                        {
                            if (!_man)
                            {
                                _woman = true;
                            }
                            else { _woman = false; }
                            break;
                        }
                }
                OnPropertyChanged();
            }
        }
        public bool ActivityLevelH
        {
            get => _activityLevelH;
            set
            {
                switch (value)
                {
                    case true:
                        _activityLevelH = true;
                        ActivL = 1.8;
                        if (_activityLevelL || _activityLevelM)
                        {
                            ActivityLevelL = false;
                            ActivityLevelM = false;
                        }
                        break;
                    case false:
                        if (_activityLevelL || _activityLevelM)
                        {
                            _activityLevelH = false;
                        }
                        else
                        {
                            _activityLevelH = true;
                            ActivityLevelL = false;
                            ActivityLevelM = false;
                        }
                        break;
                }
                OnPropertyChanged();
            }
        }
        public bool ActivityLevelM
        {
            get => _activityLevelM;
            set
            {
                switch (value)
                {
                    case true:
                        _activityLevelM = true;
                        ActivL = 1.5;
                        if (_activityLevelL || _activityLevelH)
                        {
                            ActivityLevelH = false;
                            ActivityLevelL = false;
                        }
                        break;
                    case false:
                        if (_activityLevelL || _activityLevelH)
                        {
                            _activityLevelM = false;
                        }
                        else
                        {
                            _activityLevelM = true;
                            ActivityLevelH = false;
                            ActivityLevelL = false;
                        }
                        break;
                }
                OnPropertyChanged();
            }
        }
        public bool ActivityLevelL
        {
            get => _activityLevelL;
            set
            {
                switch (value)
                {
                    case true:
                        _activityLevelL = true;
                        ActivL = 1.2;
                        if (_activityLevelM || _activityLevelH)
                        {
                            ActivityLevelH = false;
                            ActivityLevelM = false;
                        }
                        break;
                    case false:
                        if (_activityLevelM || _activityLevelH)
                        {
                            _activityLevelL = false;
                        }
                        else
                        {
                            _activityLevelL = true;
                            ActivityLevelH = false;
                            ActivityLevelM = false;
                        }
                        break;
                }
                OnPropertyChanged();
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
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
        public double Height
        {
            get => _height;
            set
            {
                if (_height != value)
                {
                    _height = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Weight
        {
            get => _weight;
            set
            {
                if (_weight != value)
                {
                    _weight = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Age
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged();

                }
            }
        }
        public double BMI
        {
            get => _bmi;
            set
            {
                if (_bmi != value)
                {
                    _bmi = value;
                    OnPropertyChanged();
                }
            }
        }
        public double BMR
        {
            get => _bmr;
            set
            {
                if (_bmr != value)
                {
                    _bmr = value;
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
