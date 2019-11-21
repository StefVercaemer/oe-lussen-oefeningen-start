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
            int positie = GeefPositie(tekst, gezochtTeken);

            if (positie == 0)
            {
                tbkFeedback.Text = "Het teken " +  gezochtTeken + " is niet gevonden";
            }
            else
            {
                tbkFeedback.Text = $"Het teken {gezochtTeken} staat op plaats {positie}";
            }
        }

        int GeefPositie(string tekst, char gezochtTeken)
        {
            int teller = 0;
            int positie = 0;
            int lengte = tekst.Length;
            char teken = (char)1;
            if (lengte > 0)
            {
                while (gezochtTeken != teken && teller < lengte)
                {
                    teken = tekst[teller];
                    if (gezochtTeken == teken)
                    {
                        positie = teller + 1;
                    }
                    teller++;
                }
            }
            return positie;
        }
    }
}
