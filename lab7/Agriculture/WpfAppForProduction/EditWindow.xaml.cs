using Production;
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

namespace WpfAppForProduction
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
    
            for (int i = 0; i < MainWindow.Products.Count; i++)
            {
                if (ComboBox.SelectedIndex == 0)
                {

                    MainWindow.Products.Remove(MainWindow.Products[i]);

                }

                if (ComboBox.SelectedIndex == 1)
                {

                    MainWindow.Products.Remove(MainWindow.Products[i]);
                }

                if (ComboBox.SelectedIndex == 2)
                {
                    MainWindow.Products.Remove(MainWindow.Products[i]);

                }
            }
            MessageBox.Show("Product/s was deleated", "Information");




        }
    }
}
