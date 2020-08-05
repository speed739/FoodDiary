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
    /// Logika interakcji dla klasy Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public RegistrationViewModel RegistrationViewModel { get; set; }
        readonly Methods Methods = new Methods();
        public Registration()
        {
            RegistrationViewModel = new RegistrationViewModel();
            DataContext = RegistrationViewModel;
            InitializeComponent();
        }
        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).RegistrationModel.Password = ((PasswordBox)sender).Password; }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            WelcomeWindow window = new WelcomeWindow();
            Methods.CloseMethod(Enum.EnumWindow.RegistrationW);
            window.ShowDialog();

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Methods.ExitMethod();
        }
    }
}
