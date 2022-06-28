using Cvet.BasaBD;
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

namespace Cvet.Pages
{
    /// <summary>
    /// Логика взаимодействия для BxodVAKK.xaml
    /// </summary>
    public partial class BxodVAKK : Page
    {
        public BxodVAKK()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (BD.connect.Users.Any(x=>x.login==Login.Text && x.password == Password.Text))
                {
                    MainWindow rf = new MainWindow();
                    rf.Show();
                    
                    Application.Current.MainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            catch 
            {
                MessageBox.Show("Неверный логин или пароль");

            }
        }
    }
}
