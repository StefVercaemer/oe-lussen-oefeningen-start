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
            BeginSituatie(true);
            btnTrekking.IsEnabled = false;
        }

        void BeginSituatie(bool getalKeuzeMogelijk)
        {
            btnRaden.IsEnabled = !getalKeuzeMogelijk;
            lstHoogsteGetal.IsEnabled = getalKeuzeMogelijk;
            lstAantalGetallen.IsEnabled = getalKeuzeMogelijk;
        }

        void CheckSelectieGetallen()
        {
            int? aantalGetallen = (int?)lstAantalGetallen.SelectedItem;
            int? hoogsteGetal = (int?)lstHoogsteGetal.SelectedItem;
            if (aantalGetallen != null &&
                hoogsteGetal != null &&
                hoogsteGetal >= aantalGetallen)
            {
                btnTrekking.IsEnabled = true;
            }
            else
            {
                btnTrekking.IsEnabled = false;
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
            btnTrekking.IsEnabled = false;
            BeginSituatie(false);

        }

        private void btnRaden_Click(object sender, RoutedEventArgs e)
        {
            List<string> pogingen = GeefRaadPogingen();
            lstTrekkingen.ItemsSource = pogingen;
            lstTrekkingen.Items.Refresh();

            lstAantalGetallen.SelectedIndex = -1;
            lstHoogsteGetal.SelectedIndex = -1;
            BeginSituatie(true);
        }


        List<string> GeefRaadPogingen()
        {
            int[] gokjes;
            string gokString;
            string teRadenString = String.Join("|", teRaden);
            List<string> feedback = new List<string>();
            int teller = 0;
            //maak een array met gegokte getallen
            do
            {
                gokjes = GeefReeksWillekeurigeGetallen(teRaden.Length, maxGetal);
                gokString = (String.Join("|", gokjes));
                feedback.Add(String.Join(" - ", gokjes));
                teller++;

            } while (gokString != teRadenString && teller <= 1000);
            Console.WriteLine("Aantal pogingen: " + teller);
            return feedback;
        }

        private void lstAantalGetallen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckSelectieGetallen();
        }

        private void lstHoogsteGetal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckSelectieGetallen();
        }
    }
}
