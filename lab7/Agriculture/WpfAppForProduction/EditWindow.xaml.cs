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
    /// The class for edit a information
    /// </summary>
    public partial class EditWindow : Window
    {
        /// <summary>
        /// Creates an instance of the EditWindow class
        /// </summary>
        public EditWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns to the main form by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Deleate product button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < MainWindow.Products.Count; i++)
            {

                if (ComboBox.SelectedIndex == 0 && MainWindow.Products[i].Type == ProdTypes.Fruits)
                {
                    MainWindow.Products.Remove(MainWindow.Products[i]);
                    i--;
                }

                if (ComboBox.SelectedIndex == 1 && MainWindow.Products[i].Type == ProdTypes.Vegetables)
                {

                    MainWindow.Products.Remove(MainWindow.Products[i]);
                    i--;
                }

                if (ComboBox.SelectedIndex == 2 && MainWindow.Products[i].Type == ProdTypes.Berries)
                {
                    MainWindow.Products.Remove(MainWindow.Products[i]);
                    i--;
                }
            }


            if (ComboBox.Text == "")
            {
                MessageBox.Show("Product/s was'n deleated");
            }
            else
            {
                MessageBox.Show("Product/s was deleated");
            }

        }
    }
}
