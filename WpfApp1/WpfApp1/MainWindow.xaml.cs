﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //last slash in dirrectory name
            string strFileNameAndPath = txtFileNameAndPath.Text;
            int intPosOfLastSlash = strFileNameAndPath.LastIndexOf(System.IO.Path.DirectorySeparatorChar);
            string strPath = strFileNameAndPath.Substring(0, intPosOfLastSlash);            
            lstBoxFileNames.ItemsSource= Directory.EnumerateFiles(strPath);




        }

        private void btnLoadTextFile_Click(object sender, RoutedEventArgs e)
        {
            txtContent.Text = File.ReadAllText(txtFileNameAndPath.Text);

        }

        private void btnSaveTextFile_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(txtFileNameAndPath.Text, txtContent.Text);
        }
    }
}
