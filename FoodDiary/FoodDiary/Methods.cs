using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FoodDiary
{
    public static class Methods
    {
        public static void ExitMethod()
        {
            List<Window> windows = new List<Window>();
            windows = Application.Current.Windows.OfType<Window>().ToList();
            windows.ForEach(x => x.Close());
        }
        public static void CloseMethod(Enum WindowName)
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
