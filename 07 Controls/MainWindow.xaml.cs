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

namespace _07_Controls
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

        private void BtnTextBoxen_Click(object sender, RoutedEventArgs e)
        {
            //Toon de naam van alle textboxen in tbkFeedBack

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtDrie.Text = "3";
            txtTwee.Text = "2";
            txtEen.Text = "1";

            cmbJaNee.Items.Add("Ja");
            cmbJaNee.Items.Add("Nee");
            cmbJaNee.SelectedIndex = 0;
        }

        private void BtnWisInPut_Click(object sender, RoutedEventArgs e)
        {
            //Overloop alle controls in grdMainGrid (gebruik de property Children)
            //Maak alle labels die een naam hebben en alle textboxen leeg
            //Maak de selectie in cmbJaNee ongedaan

        }

        private void CmbJaNee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbJaNee.SelectedIndex >= 0)
            {
                lblKeuze.Content = "Keuze: " + cmbJaNee.SelectedItem;
            }
        }
    }
}
