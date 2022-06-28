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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Bxod.xaml
    /// </summary>
    public partial class Bxod : Window
    {
        public Bxod()
        {
            InitializeComponent();
        }

      

       

        private void Exit2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Bxod32_Click(object sender, RoutedEventArgs e)
        {
            MineFrame.NavigationService.Navigate(new BxodPages());

        }
    }
}
