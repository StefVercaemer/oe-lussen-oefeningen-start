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

namespace LetterZoeker.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnZoekA_Click(object sender, RoutedEventArgs e)
        {
            string tekst = txtTekst.Text;
            char gezochtTeken = 'A';
            char teken = (char)66;
            int teller = 0;
            int positie = 0;
            int lengte = tekst.Length;
            if (lengte > 0)
            {
                while (gezochtTeken != teken &&  teller < lengte)
                {
                    teken = tekst[teller];
                    if (gezochtTeken == teken)
                    {
                        positie = teller + 1;
                     }
                    teller++;
                }
            }

            if (positie == 0)
            {
                Console.WriteLine(gezochtTeken.ToString() + " is niet gevonden");
            }
            else
            {
                Console.WriteLine($"Het {teken} staat op plaats {positie}");
            }
        }
    }
}
