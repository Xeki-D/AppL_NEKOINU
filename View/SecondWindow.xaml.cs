using System;
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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        string connectionString = "Server=localhost;Database=nekoinu_bdd;Uid=root;Pwd=";
        bool connecte = false;
        MySqlConnection connection;

        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*var nom = txb_nameP.Text;
            var prix = Double.Parse(txb_prixP.Text);
            var stock = Int32.Parse(txb_stockP.Text);
            var desc = txb_descP.Text;
            var img = txb_imgP.Text;
            var animal = Int32.Parse(txb_animalP.Text);

            addP.getLeProduit(nom, prix, stock, desc, img, animal);*/

            connection = new MySqlConnection(connectionString);

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    connecte = true;

                    
                    try
                    {
                        string query = "INSERT INTO produit (NOM_PRODUIT,PRIX_PRODUIT,STOCK_PRODUIT,DESC_PRODUIT,IMG_PRODUIT,ANIMAL_PRODUIT) VALUES(@nom, @prix, @stock, @desc, @img, @animal)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlParameter nomParam = new MySqlParameter("@nom", MySqlDbType.Text, 100);
                        MySqlParameter prixParam = new MySqlParameter("@prix", MySqlDbType.Double, 100);
                        MySqlParameter stockParam = new MySqlParameter("@stock", MySqlDbType.Int32, 100);
                        MySqlParameter descParam = new MySqlParameter("@desc", MySqlDbType.Text, 100);
                        MySqlParameter imgParam = new MySqlParameter("@img", MySqlDbType.Text, 100);
                        MySqlParameter animalParam = new MySqlParameter("@animal", MySqlDbType.Int32, 1);

                        nomParam.Value = txb_nameP.Text;
                        prixParam.Value = txb_prixP.Text;
                        stockParam.Value = txb_stockP.Text;
                        descParam.Value = txb_descP.Text;
                        imgParam.Value = txb_imgP.Text;
                        animalParam.Value = txb_animalP.Text;


                        cmd.Parameters.Add(nomParam);
                        cmd.Parameters.Add(prixParam);
                        cmd.Parameters.Add(stockParam);
                        cmd.Parameters.Add(descParam);
                        cmd.Parameters.Add(imgParam);
                        cmd.Parameters.Add(animalParam);

                        // Call Prepare after setting the Commandtext and Parameters.
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        
                    }
                    catch (MySqlException co)
                    {
                        Console.WriteLine("Error Generated. Details: " + co.ToString());
                    }
                }
                connection.Close();
                MessageBox.Show("Insertion produit validé");
                this.Close();
            }
            catch (MySqlException co)
            {
                MessageBox.Show(co.ToString());
                MessageBox.Show("Non Connecté");
            }
        }
    }
}
