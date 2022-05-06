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
    /// Logique d'interaction pour First.xaml
    /// </summary>
    public partial class First : Window
    {
        string connectionString = "Server=localhost;Database=nekoinu_bdd;Uid=root;Pwd=";
        bool connecte = false;
        MySqlConnection connection;
        public First()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    connecte = true;
                    ListView1.Items.Clear();

                    string query = "SELECT * FROM produit";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    using (MySqlDataReader lecture = cmd.ExecuteReader())
                    {
                        while (lecture.Read())
                        {
                            
                            string ID = lecture["ID_PRODUIT"].ToString();
                            string Nom = lecture["NOM_PRODUIT"].ToString();
                            string Prix = lecture["PRIX_PRODUIT"].ToString();
                            string Stock = lecture["STOCK_PRODUIT"].ToString();
                            string Animal = lecture["ANIMAL_PRODUIT"].ToString();

                            //string[] ProduitList ={ ID, Nom, Prix, Stock, Description, Image, Animal };
                            //var ListViewItem lvi = new ListViewItem(ProduitList);
                            string Produit = "ID : "+ID+"\n"+"Nom : " + Nom + "\n"+"Prix : " + Prix + "\n" + "Stock : " + Stock + "\n"+ "Animal : " + Animal + "\n";
                            ListView1.Items.Add(Produit);


                        }
                    }

                }
            }
            catch (MySqlException co)
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Non Connecté");
            }
            


        }

        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            connection = new MySqlConnection(connectionString);

            if (connecte)
            {
                if(ListView1.SelectedItems.Count > 0)
                {
                    MessageBox.Show(ListView1.SelectedItem.ToString());
                }
            }
    }
    }
}
