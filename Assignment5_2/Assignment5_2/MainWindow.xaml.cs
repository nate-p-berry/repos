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

namespace Assignment5_2
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

        private void Show_People_Click(object sender, RoutedEventArgs e)
        {
            PersonGrid personGrid = new();
            personGrid.Show();
        }
        private void Add_Data_Click(object sender, RoutedEventArgs e)
        {
            AddPersonWindow addPersonWindow = new();
            addPersonWindow.Show();
        }
        private void Delete_Data_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Search_Data_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
