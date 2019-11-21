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

namespace WpfLusIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] fruitMand = { "appel", "peer", "perzik", "kers" };
		
		public MainWindow()
        {
            InitializeComponent();
        }


        private void btnFruit_Click(object sender, RoutedEventArgs e)
        {
            string fruitInfo = "";

            lstFruit.ItemsSource = fruitMand;
            lstFruit.Items.Refresh();

            foreach (string fruit in fruitMand)
            {
                fruitInfo += fruit + "\n";
            }

            lblFruitmand.Content = fruitInfo;

        }

        private void btnPeerPlaats_Click(object sender, RoutedEventArgs e)
        {
            string fruitNaam = "";
            int index = 0;

            Array.Sort(fruitMand);
            lstFruit.ItemsSource = fruitMand;
            lstFruit.Items.Refresh();

            do
            {
                fruitNaam = fruitMand[index];
                index++;
            } while (fruitNaam != "peer");

            lblPeerPlaats.Content = "Plaats peer: " + (index);
        }

        private void btnPareGetallen_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 20; i += 2)
            {
                lstGetallen.Items.Add(i);
            }
        }

        private void btnEerstePunt_Click(object sender, RoutedEventArgs e)
        {
            int plaats = 0;
            string huidigTeken = "";
            string tekstBron = lblTekst.Content.ToString();

            while (huidigTeken != ".")
            {
                huidigTeken = tekstBron[plaats].ToString();
                plaats++;
            }

            //een string is een array van chars, die we met foreach kunnen doorlopen
            foreach (char teken in tekstBron)
            {
                if (teken == '.')
                {
                    break; // onderbreekt de lus.
                }
                plaats++;
            }

            MessageBox.Show("De eerste punt staat op plaats " + plaats);
        }
    }
}
