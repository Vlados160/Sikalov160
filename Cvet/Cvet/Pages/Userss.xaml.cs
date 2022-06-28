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
    /// Логика взаимодействия для Userss.xaml
    /// </summary>
    public partial class Userss : Page
    {
        public Users newUs { get; set; }
        public Userss()
        {
            InitializeComponent();
            this.newUs = new Users();
            LsT.ItemsSource = BD.connect.Users.ToList();
            this.DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = LsT.SelectedItem as ShelestEntities;
        }
    }
}
