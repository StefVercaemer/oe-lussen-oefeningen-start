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

namespace WpfTafels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //vul cmbKiesTafel met de getallen van 1 - 10
            for (int i = 1; i <= 10; i++)
            {
                cmbKiesTafel.Items.Add(i);
            }
        }

        void ToonTafel(int tafel, bool maakEerstLeeg = true)
        {
            if (maakEerstLeeg)
            {
                lstTafels.Items.Clear();

            }
            for (int i = 1; i < 11; i++)
            {
                int product = i * tafel;
                string tafelUitgeschreven = $"{i} X {tafel} = {product}";
                lstTafels.Items.Add(tafelUitgeschreven);
            }
        }

        private void btnTafel5_Click(object sender, RoutedEventArgs e)
        {
            ToonTafel(5);
        }


        private void cmbKiesTafel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbKiesTafel.SelectedItem != null)
            {
                int tafel = (int)cmbKiesTafel.SelectedItem;
                ToonTafel(tafel);
            }

        }

        private void btnAlleTafels_Click(object sender, RoutedEventArgs e)
        {
            lstTafels.Items.Clear();

            for (int tafel = 1; tafel < 11; tafel++)
            {
                ToonTafel(tafel, false);
                //for (int i = 1; i < 11; i++)
                //{
                //    int product = i * tafel;
                //    string tafelUitgeschreven = $"{i} X {tafel} = {product}";
                //    lstTafels.Items.Add(tafelUitgeschreven);
                //}
                lstTafels.Items.Add("------------------");
            }

        }
    }
}
