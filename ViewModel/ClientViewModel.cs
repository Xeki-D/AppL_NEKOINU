using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp_NEKOINU.Model;
using WpfApp_NEKOINU.View;
//using MainWindows.xaml;

namespace WpfApp_NEKOINU.ViewModel
{
    public class ClientViewModel : INotifyPropertyChanged
    {

        Model1 obj = new Model1();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            /*
            if (PropertyChangedEventArgs != null)
            {
                PropertyChangedEventArgs(this, new PropertyChangedEventArgsEventArgs(propName));
            }*/
        }

        public client getLeClient(string login, string mdp)
        {
            var cli = from cat1 in obj.client
                      where cat1.ADR_CLIENT == login
                      where cat1.MDP_CLIENT == mdp
                      select cat1;
            
            if (cli != null)
            {
                
                SecondWindow f = new SecondWindow();
                f.Show();
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
