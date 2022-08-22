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
using System.Windows.Shapes;

namespace Assignment5_2
{
    /// <summary>
    /// Interaction logic for PersonGrid.xaml
    /// </summary>
    public partial class PersonGrid : Window
    {
        public PersonGrid()
        {
            PeopleDictionary pairs = new();
            DataGrid dataGrid = new();
            foreach (var person in pairs)
            {
                dataGrid.Items.Add(person);
            }
            if (pairs.Count == 0)
            {
                MessageBox.Show("Null List", "No one has been added to our registry yet.", MessageBoxButton.OK, MessageBoxImage.Error);
            } else
            {
                InitializeComponent();
            }
        }
    }
}
