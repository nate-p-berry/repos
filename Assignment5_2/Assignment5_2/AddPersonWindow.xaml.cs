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

namespace Assignment5_2
{
    /// <summary>
    /// Interaction logic for AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        internal void AddPersonButton_Click(object sender, RoutedEventArgs e)
        {
            Person person = new()
            {
                FirstName = Convert.ToString(txtFirstName),
                LastName = Convert.ToString(txtLastName),
                MobileNumber = Convert.ToString(txtMobileNumber),
                WorkNumber = Convert.ToString(txtWorkNumber),
                Address = Convert.ToString(txtAddress)
            };
            
            this.Close();
        }
    }
}
