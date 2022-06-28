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
    /// Логика взаимодействия для AgentList.xaml
    /// </summary>
    public partial class AgentList : Page
    {
        public Agent ListAgent { get; set; }
        public AgentList()
        {
            InitializeComponent();
            this.ListAgent = new Agent();
            LsV.ItemsSource = BD.connect.Agent.ToList();
            this.DataContext = this;
        }

        private void LsV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = LsV.SelectedItem as ShelestEntities;
        }

        private void Poi_TextChanged(object sender, TextChangedEventArgs e)
        {
            LsV.ItemsSource = BD.connect.Agent.Where(x => x.Title.StartsWith(Poi.Text)).ToList();
        }
    }
}
