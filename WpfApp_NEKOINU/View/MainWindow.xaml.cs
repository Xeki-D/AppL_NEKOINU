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
using MySql.Data.MySqlClient;

namespace WpfApp_NEKOINU.View
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = "Server=localhost;Database=nekoinu_bdd;Uid=root;Pwd=";
        bool connecte = false;
        MySqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            connection = new MySqlConnection(connectionString);
            try
            {

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    connecte = true;
                    string query = "Select Count(1) FROM client WHERE ADR_CLIENT=@adr AND MDP_CLIENT=@mdp";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlParameter adr = new MySqlParameter("@adr", txb_login.Text);
                    MySqlParameter mdp = new MySqlParameter("@mdp", txb_mdp.Password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if(count == 1)
                    {

                       
                        SelectionWindows select = new SelectionWindows();
                        select.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant incorrect");
                    }


                }
            }
            catch (Exception co)
            {
                MessageBox.Show(co.ToString());
            }

        }

        private void txb_login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txb_mdp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
