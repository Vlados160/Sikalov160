using Krasota.Pages;
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

namespace Krasota
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MineFrame.NavigationService.Navigate(new AgentData());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MineFrame.NavigationService.Navigate(new AgentList());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Bxod11 rd = new Bxod11();
            rd.Show();
            this.Close();
        }
    }
}
