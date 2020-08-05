using FoodDiary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDiary.Model
{
    public class UserModel
    {
        public string Username, Password, Sex, Activity;
        public double Weight, Height, Age, BMI, BMR;

        public UserModel(RegistrationModel model)
        {
            Username = model.Username;
            Password = model.Password;
            Weight = model.Weight;
            Height = model.Height;
            Age = model.Age;
            BMI = model.BMI;
            BMR = model.BMR;

            if (model.Man)
            {
                Sex = EnumSex.Man.ToString();
            }
            else
                Sex = EnumSex.Woman.ToString();

            if (model.ActivityLevelL) Activity = EnumActivity.Low.ToString();
            if (model.ActivityLevelM) Activity = EnumActivity.Medium.ToString();
            if (model.ActivityLevelH) Activity = EnumActivity.High.ToString();
        }
    }
}
