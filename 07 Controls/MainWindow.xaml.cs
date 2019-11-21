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

        void WisInput(Panel panel)
        {
            foreach (object control in panel.Children)
            {
                Type type = control.GetType();
                if (type == (typeof(Label)))
                {
                    Label label = (Label)control;
                    if (label.Name.Length > 0)
                    {
                        label.Content = "";
                    }
                }
                else if (type == (typeof(TextBox)))
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = "";
                }
                else if (type == (typeof(TextBlock)))
                {
                    TextBlock textBlock = (TextBlock)control;
                    textBlock.Text = "";
                }
                else if (type == (typeof(ComboBox)))
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = -1;
                }
                else if (type == (typeof(ListBox)))
                {
                    ListBox listBox = (ListBox)control;
                    listBox.SelectedIndex = -1;
                }
            }
        }

        private void BtnTextBoxen_Click(object sender, RoutedEventArgs e)
        {
            string info = "";
            foreach (object control in grdMainGrid.Children)
            {
                Type type;
                type = control.GetType();
                if (type == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;
                    info += textBox.Name + "\n";
                }
            }
            tbkFeedBack.Text = info;
        }

        private void BtnWisInPut_Click(object sender, RoutedEventArgs e)
        {
            WisInput(grdMainGrid);
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


        private void CmbJaNee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbJaNee.SelectedIndex >= 0)
            {
                lblKeuze.Content = "Keuze: " + cmbJaNee.SelectedItem;
            }
        }
    }
}
