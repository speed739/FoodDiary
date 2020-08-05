using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FoodDiary.Enum;

namespace FoodDiary
{
    public  class Methods
    {
        public void ExitMethod()
        {
            List<Window> windows = new List<Window>();
            windows = Application.Current.Windows.OfType<Window>().ToList();
            windows.ForEach(x => x.Close());
        }
        public void CloseMethod(EnumWindow WindowName)
        {
            List<Window> windows = new List<Window>();
            windows = Application.Current.Windows.OfType<Window>().ToList();
            windows.ForEach(x =>
            { 
                if(x.Name == WindowName.ToString())
                {
                    x.Close();
                }
            });
        }
    }
}
