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
        }

        private void btnTafel5_Click(object sender, RoutedEventArgs e)
        {
            //Maak lstTafels leeg
            //Vul lstTafels met de tafel van 5
        }


        private void cmbKiesTafel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Maak lstTafels leeg
            //Vul lstTafels met de gekozen tafel
        }

        private void btnAlleTafels_Click(object sender, RoutedEventArgs e)
        {
            //Maak lstTafels leeg
            //Vul lstTafels met de tafels van 1 ==> 10
            //Onder elke tafel komt een lijn

        }
    }
}
