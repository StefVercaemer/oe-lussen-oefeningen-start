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

namespace _04_Lotto.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int[] teRaden;
        int maxGetal;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 7; i++)
            {
                lstAantalGetallen.Items.Add(i);
                lstHoogsteGetal.Items.Add(i);
            }
            for (int i = 7; i <= 45; i++)
            {
                lstHoogsteGetal.Items.Add(i);
            }
        }

        int[] GeefReeksWillekeurigeGetallen(int aantalGetallen, int maxWaarde)
        {
            int[] reeks = new int[aantalGetallen];
            for (int i = 0; i < reeks.Length; i++)
            {
                int willekeurigGetal;
                do
                {
                    willekeurigGetal = random.Next(1, maxWaarde + 1);
                    Console.WriteLine(willekeurigGetal);
                } while (reeks.Contains(willekeurigGetal));
                reeks[i] = willekeurigGetal;
            }
            Array.Sort(reeks);
            Console.WriteLine("Reeks: " + String.Join(" - ", reeks));
            return reeks;
        }

        private void btnTrekking_Click(object sender, RoutedEventArgs e)
        {
            int aantalGetallen = (int)lstAantalGetallen.SelectedItem;
            maxGetal = (int)lstHoogsteGetal.SelectedItem;
            teRaden = GeefReeksWillekeurigeGetallen(aantalGetallen, maxGetal);
        }

        private void btnRaden_Click(object sender, RoutedEventArgs e)
        {

            //maak een array met gegokte getallen
            int[] gokjes = GeefReeksWillekeurigeGetallen(teRaden.Length, maxGetal);
            /*int[] gokjes = new int[teRaden.Length];
            for (int i = 0; i < gokjes.Length; i++)
            {
                int gok;
                do
                {
                    gok = random.Next(1, maxGetal + 1);
                    //Console.WriteLine(gok);
                } while (gokjes.Contains(gok));
                gokjes[i] = gok;
            }
            Array.Sort(gokjes);
            Console.WriteLine(String.Join(" - ", gokjes));
            */
            if (teRaden == gokjes)
            {
                Console.WriteLine("Geraden");
            }
            //zorg dat de gokken uniek zijn
            //sorteer ze
            //vergelijk met teRaden
            //blijf dit doen tot je het geraden hebt

        }
    }
}
