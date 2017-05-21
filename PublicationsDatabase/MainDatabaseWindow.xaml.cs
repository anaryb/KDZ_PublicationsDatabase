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
using System.Windows.Shapes;

namespace PublicationsDatabase
{
    /// <summary>
    /// Логика взаимодействия для MainDatabaseWindow.xaml
    /// </summary>
    public partial class MainDatabaseWindow : Window
    {
        public MainDatabaseWindow()
        {
            InitializeComponent();
            MainDatabaseFrame.Navigate(Pages.MainDatabasePage);

        }


    }
}
