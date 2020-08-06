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
using LiveCharts.Wpf;
using LiveCharts;
using FoodDiary.ViewModel;

namespace FoodDiary.View
{
    /// <summary>
    /// Logika interakcji dla klasy UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindowViewModel UserW_ViewModel { get; set; }
        public UserWindow()
        {
            UserW_ViewModel = new UserWindowViewModel();
            DataContext = UserW_ViewModel;
            InitializeComponent();
        }
        
        private void Log_Out_Click(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            Close();
            log.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Methods Methods = new Methods();
            Methods.ExitMethod();
        }
    }
}
