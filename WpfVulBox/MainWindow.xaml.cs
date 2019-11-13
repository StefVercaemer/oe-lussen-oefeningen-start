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

namespace WpfVulBox
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtVan.Text = "1";
            txtTot.Text = "10";
            txtSprong.Text = "2";
        }

        private void btnVulListBox_Click(object sender, RoutedEventArgs e)
        {
            int van, tot, sprong;
            lstGetallenlijst.Items.Clear();
            try
            {
                van = int.Parse(txtVan.Text);
                tot = int.Parse(txtTot.Text);
                sprong = int.Parse(txtSprong.Text);

                for (int i = van; i <= tot; i+=sprong)
                {
                    lstGetallenlijst.Items.Add(i);
                }
                Title = "";
            }
            catch (Exception)
            {

                Title = "Geef geldige getallen";
            }

        }

        private void btnVulComboBox_Click(object sender, RoutedEventArgs e)
        {
            int van, tot, sprong;
            cmbGetallenLijst.Items.Clear();
            try
            {
                van = int.Parse(txtVan.Text);
                tot = int.Parse(txtTot.Text);
                if (van < tot)
                {
                    int temp = van;
                    van = tot;
                    tot = temp;
                }
                sprong = int.Parse(txtSprong.Text);

                for (int i = van; i >= tot; i -= sprong)
                {
                    cmbGetallenLijst.Items.Add(i);
                }
                Title = "";
            }
            catch (Exception)
            {

                Title = "Geef geldige getallen";
            }
        }
    }
}
