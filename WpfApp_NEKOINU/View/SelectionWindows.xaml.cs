using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
using WpfApp_NEKOINU.ViewModel;
using MySql.Data.MySqlClient;


namespace WpfApp_NEKOINU.View
{
    /// <summary>
    /// Logique d'interaction pour SelectionWindows.xaml
    /// </summary>
    public partial class SelectionWindows : Window
    {
        public SelectionWindows()
        {
            InitializeComponent();
        }

        private void bt_ViewP_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow s = new SecondWindow();
            s.Show();
        }

        private void bt_ViewP_Click_1(object sender, RoutedEventArgs e)
        {
            First t = new First();
            t.Show();
        }

        private void bt_AddP_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow s = new SecondWindow();
            s.Show();
        }
    }
}
