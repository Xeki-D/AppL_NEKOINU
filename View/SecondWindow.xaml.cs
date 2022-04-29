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
using System.Windows.Shapes;
using WpfApp_NEKOINU.ViewModel;

namespace WpfApp_NEKOINU.View
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        AddProduit addP = new AddProduit();
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nom = txb_nameP.Text;
            var prix = Double.Parse(txb_prixP.Text);
            var stock = Int32.Parse(txb_stockP.Text);
            var desc = txb_descP.Text;
            var img = txb_imgP.Text;
            var animal = Int32.Parse(txb_animalP.Text);

            addP.getLeProduit(nom, prix, stock, desc, img, animal);
        }
    }
}
