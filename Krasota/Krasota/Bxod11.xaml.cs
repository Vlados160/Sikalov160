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
using Krasota.Pages;

namespace Krasota
{
    /// <summary>
    /// Логика взаимодействия для Bxod11.xaml
    /// </summary>
    public partial class Bxod11 : Window
    {
        public Bxod11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MineFrame12.NavigationService.Navigate(new BxodPag());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
