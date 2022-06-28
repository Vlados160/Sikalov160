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
    /// Логика взаимодействия для AgentList.xaml
    /// </summary>
    public partial class AgentList : Page
    {
        public Agent AgentList1 { get; set; }
        public AgentList()
        {
            InitializeComponent();
            this.AgentList1 = new Agent();
            Lsv.ItemsSource = BD.connect.Agent.ToList();
            this.DataContext = this;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = Lsv.SelectedItem as ShelestEntities;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Lsv.ItemsSource = BD.connect.Agent.Where(x => x.Title.StartsWith(Pois.Text)).ToList();
        }
    }
}
