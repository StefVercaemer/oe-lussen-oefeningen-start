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

namespace WpfTekstOmkering
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

        string KeerTekstOm1(string omTeKeren)
        {
            string omgekeerd = "";
            int lengte;
            lengte = omTeKeren.Length;
            for (int i = 0; i < lengte; i++)
            {
                char teken;
                teken = omTeKeren[i];
                omgekeerd = teken + omgekeerd;
            }
            return omgekeerd;
        }

        string KeerTekstOm2(string omTeKeren)
        {
            string omgekeerd = "";
            int lengte;
            lengte = omTeKeren.Length;
            for (int i = lengte - 1; i >= 0; i--)
            {
                char teken;
                teken = omTeKeren[i];
                omgekeerd += teken;
            }
            return omgekeerd;
        }

        string KeerTekstOmForEach(string omTeKeren)
        {
            string omgekeerd = "";

            foreach (char teken in omTeKeren)
            {
                omgekeerd = teken + omgekeerd;
            }
            return omgekeerd;
        }

        string GeefAlfabet(char beginLetter, bool omkeren)
        {
            string alfabet = "";
            int beginWaarde;
            beginWaarde = (int)beginLetter;
            for (int i = 0; i < 26; i++)
            {
                char letter;
                int ascii;
                ascii = i + beginWaarde;
                letter = (char)ascii;
                alfabet += letter;
            }
            if (omkeren)
            {
                alfabet = KeerTekstOm1(alfabet);
            }
            return alfabet;
        }

        private void btnOmkeren_Click(object sender, RoutedEventArgs e)
        {
            string tekst;

            tekst = txtOmTeKeren.Text;

            lblOmgekeerd.Content = KeerTekstOmForEach(tekst);

        }

        private void BtnKleineLetters_Click(object sender, RoutedEventArgs e)
        {
            string alfabet = "";
            alfabet = GeefAlfabet('a', false);
            tbkAlfabet.Text += "\n" + alfabet;

        }

        private void BtnGroteLetters_Click(object sender, RoutedEventArgs e)
        {
            string alfabet = "";
            alfabet = GeefAlfabet('A', false);
            tbkAlfabet.Text += "\n" + alfabet;
        }

        private void BtnZnaarA_Click(object sender, RoutedEventArgs e)
        {
            string alfabet = "";
            alfabet = GeefAlfabet('A', true);
            tbkAlfabet.Text += "\n" + alfabet;
        }

    }
}
