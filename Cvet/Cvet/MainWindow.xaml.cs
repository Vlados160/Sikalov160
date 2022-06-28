using Cvet.Pages;
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

namespace Cvet
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
            Application.Current.Shutdown();
        }

        private void AgentData_Click(object sender, RoutedEventArgs e)
        {
            MineFrame.NavigationService.Navigate(new AgentData());
        }

        private void AgentList_Click(object sender, RoutedEventArgs e)
        {
            MineFrame.NavigationService.Navigate(new AgentList());
        }

        private void UserList_Click(object sender, RoutedEventArgs e)
        {
            MineFrame.NavigationService.Navigate(new Userss());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Bxod gt = new Bxod();
            gt.Show();
            this.Close();
        }
    }
}
