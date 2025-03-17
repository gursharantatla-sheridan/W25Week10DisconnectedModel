﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace W25Week10DisconnectedModel;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Data data = new Data();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
    {
        grdProducts.ItemsSource = data.GetAllProducts().DefaultView;
    }

    private void btnShowWindow2_Click(object sender, RoutedEventArgs e)
    {
        DataSetWithMultipleTables win2 = new DataSetWithMultipleTables();
        win2.Show();
    }
}