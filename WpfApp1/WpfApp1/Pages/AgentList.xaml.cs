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
using System.IO;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AgentList.xaml
    /// </summary>
    public partial class AgentList : Page
    {
        public Agent ListAgent { get; set; }
        public AgentList()
        {
            InitializeComponent();
            this.ListAgent = new Agent();
            LsT.ItemsSource = BD.connect.Agent.ToList();
            this.DataContext = this;
        }

        private void LsT_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = LsT.SelectedItem as ShelestEntities;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            LsT.ItemsSource = BD.connect.Agent.Where(x => x.Title.StartsWith(Pol.Text)).ToList();
        }
    }
}
