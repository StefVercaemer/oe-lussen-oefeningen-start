﻿using System;
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

namespace WpfGetallenTot10
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

    private void btnToonGetallen_Click(object sender, RoutedEventArgs e)
    {
            //Toon de getallen van 1 t.e.m. 10 in lstGetallen
            lstGetallen.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                lstGetallen.Items.Add(i);
            }
    }

    private void btnReset_Click(object sender, RoutedEventArgs e)
    {
            lstGetallen.Items.Clear();
        }
}
}
