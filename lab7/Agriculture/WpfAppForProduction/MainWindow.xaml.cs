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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppForProduction
{
    /// <summary>
    /// The class representing a form that implements the interface of the application menu
    /// </summary>

    public partial class MainWindow : Window
    {
        /// <summary>
        /// List of products
        /// </summary>

        public static List<InfoAboutProduction> Products = new List<InfoAboutProduction>();
        /// <summary>
        ///  Creates an instance of the Main class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// show add window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow();
            add.ShowDialog();
        }

        /// <summary>
        /// show information window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow show = new ShowWindow();
            show.ShowDialog();
        }

        /// <summary>
        /// Show products window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductsWindow prod = new ProductsWindow();
            prod.ShowDialog();
        }
        /// <summary>
        /// Close programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Show edit window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EditWindow edit = new EditWindow();
            edit.ShowDialog();
        }
    }
}
