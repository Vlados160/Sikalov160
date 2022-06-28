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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для BxodPages.xaml
    /// </summary>
    public partial class BxodPages : Page
    {
        public BxodPages()
        {
            InitializeComponent();
        }

        private void Bxod1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BD.connect.Users.Any(x => x.login == LoginBox.Text && x.password == PasswordBox.Text))
                {
                    MainWindow fr = new MainWindow();
                    fr.Show();
                    Application.Current.MainWindow.Close();
                    MessageBox.Show("Вошел");
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch
            {

                MessageBox.Show("ОшибкаЭ");
            }
        }
    }
}
