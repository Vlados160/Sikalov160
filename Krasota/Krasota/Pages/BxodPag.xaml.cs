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

namespace Krasota.Pages
{
    /// <summary>
    /// Логика взаимодействия для BxodPag.xaml
    /// </summary>
    public partial class BxodPag : Page
    {
        public BxodPag()
        {
            InitializeComponent();
        }

        private void ADDBX_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              if (BD.connect.Users.Any(x => x.login == Login.Text && x.password == Password.Text))
              {
                MainWindow rd = new MainWindow();
                rd.Show();
                Application.Current.MainWindow.Close();
               }
                else
                {
                    MessageBox.Show("Не верный пароль");

                    Login.Text = " ";
                    Password.Text = " ";
                }
            }
            catch 
            {
                MessageBox.Show("Не верный пароль");
            }
            
            
        }
    }
}
