using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_NEKOINU.Model;

namespace WpfApp_NEKOINU.ViewModel
{
    class AddProduit : INotifyPropertyChanged
    {
        Model1 obj = new Model1();
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            /*if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }*/
        }

        public produit getLeProduit(string nom, double prix,int stock,string desc, string img, int animal)
        {
            var prod = from cat1 in obj.produit
                      where cat1.NOM_PRODUIT == nom
                      where cat1.PRIX_PRODUIT == prix
                      where cat1.STOCK_PRODUIT == stock
                      where cat1.DESC_PRODUIT == desc
                      where cat1.IMG_PRODUIT == img
                      where cat1.ANIMAL_PRODUIT == animal
                      select cat1;
            if (prod != null)
            {
                produit objProduit = new produit();
                objProduit.NOM_PRODUIT = nom;
                objProduit.PRIX_PRODUIT = prix;
                objProduit.STOCK_PRODUIT = stock;
                objProduit.DESC_PRODUIT = desc;
                objProduit.IMG_PRODUIT = img;
                objProduit.ANIMAL_PRODUIT = animal;
                this.obj.produit.Add(objProduit);
                /*this.obj.SaveChanges();*/
                

            }
            else
            {
                string message = "Erreur";
                MessageBox.Show(message);
                
            }
            return null;
        }


    }
}
