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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace schoolangl.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizatePage.xaml
    /// </summary>
    public partial class AutorizatePage : Page
    {
        public AutorizatePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Password == "0000")
            {
                App.isAdmin = true;
                MessageBox.Show("Здравствуйте!Вы вошли как админ!");
            }
            else
            {
                MessageBox.Show("Здравствуйте!Вы вошли как пользователь!");
            }
            NavigationService.Navigate(new ServiceListPage());
        }

    }
}
