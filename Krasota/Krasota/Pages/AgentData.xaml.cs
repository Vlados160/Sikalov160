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
    /// Логика взаимодействия для AgentData.xaml
    /// </summary>
    public partial class AgentData : Page
    {
        public Agent newAgent { get; set; }
        public AgentData()
        {
            InitializeComponent();
            this.newAgent = new Agent();
            Dtg.ItemsSource = BD.connect.Agent.ToList();
            this.DataContext = this;
        }

        private void Dtg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = Dtg.SelectedItem as ShelestEntities;
        }

        private void Addz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            BD.connect.Agent.Add(this.newAgent);
            BD.connect.SaveChanges();
            MessageBox.Show("Добавлено");
            Dtg.ItemsSource = BD.connect.Agent.ToList();


                Db1.Text = "";
                Db2.Text = "";
                Db3.Text = "";
                Db4.Text = "";
                Db5.Text = "";
                Db6.Text = "";
                Db7.Text = ""; 
                Db8.Text = "";
                Db9.Text = "";
                Db10.Text = "";

            }
            catch 
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Dell_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.connect.Agent.Remove(Dtg.SelectedItem as Agent);
                BD.connect.SaveChanges();
                MessageBox.Show("Удалено");
                Dtg.ItemsSource = BD.connect.Agent.ToList();

            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
