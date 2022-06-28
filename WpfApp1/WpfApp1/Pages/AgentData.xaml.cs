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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AgentData.xaml
    /// </summary>
    public partial class AgentData : Page
    {
        public Agent DataAgent { get; set; }
        public AgentData()
        {
            InitializeComponent();
            this.DataAgent = new Agent();
            DtG.ItemsSource = BD.connect.Agent.ToList();
            this.DataContext = this;
        }

        private void DtG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items = DtG.SelectedItem as ShelestEntities;
        }

        private void Addc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.connect.Agent.Add(this.DataAgent);
                BD.connect.SaveChanges();
                MessageBox.Show("Добавлено");
                DtG.ItemsSource = BD.connect.Agent.ToList();

                Db1.Text = " ";
                Db2.Text = " ";
                Db3.Text = " ";
                Db4.Text = " ";
                Db5.Text = " ";
                Db6.Text = " ";
                Db7.Text = " ";
                Db8.Text = " ";
                Db9.Text = " ";
                Db10.Text = " ";
            }
            catch 
            {
                MessageBox.Show("Ошибка");

                Db1.Text = " ";
                Db2.Text = " ";
                Db3.Text = " ";
                Db4.Text = " ";
                Db5.Text = " ";
                Db6.Text = " ";
                Db7.Text = " ";
                Db8.Text = " ";
                Db9.Text = " ";
                Db10.Text = " ";
            }
          

        }

        private void Dell_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BD.connect.Agent.Remove(DtG.SelectedItem as Agent);
                BD.connect.SaveChanges();
                MessageBox.Show("Удалено");
                DtG.ItemsSource = BD.connect.Agent.ToList();
             
            }
            catch
            {
                MessageBox.Show("Ошибка");

             
            }
        }
    }
}
