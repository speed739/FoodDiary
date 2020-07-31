using FoodDiary.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FoodDiary.View
{
    /// <summary>
    /// Logika interakcji dla klasy WelcomeWindow.xaml
    /// </summary>
    public partial class WelcomeWindow : Window
    {
        public WelcomeWindowViewModel WelcomeWindowViewModel;
        public WelcomeWindow()
        {
            WelcomeWindowViewModel = new WelcomeWindowViewModel();
            DataContext = WelcomeWindowViewModel;
            InitializeComponent();
        }
    }
}
