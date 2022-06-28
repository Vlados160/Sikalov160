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

namespace QQ112.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewUser.xaml
    /// </summary>
    public partial class NewUser : Page
    {
        public Users NewUserss { get; set; }
        public NewUser()
        {
            InitializeComponent();
            this.NewUserss = new Users();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BD.connect.Users.Add(this.NewUserss);
            BD.connect.SaveChanges();
            MessageBox.Show("Успех");
        }
    }
}
