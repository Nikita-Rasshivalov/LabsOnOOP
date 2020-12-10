using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfAppForProduction
{
    /// <summary>
    /// Class ProductWindow
    /// </summary>
    public partial class ProductsWindow : Window
    {
        /// <summary>
        ///  Creates an instance of the ProductsWindow class
        /// </summary>
        public ProductsWindow()
        {
            InitializeComponent();
            adding();
        }

        /// <summary>
        /// Returns on main page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Method of adding products in table
        /// </summary>
       void adding()
        {
            int num = 1;
            foreach (var prod in MainWindow.Products)
            {   
                Info Info = new Info(prod.Type,prod.kind,prod.PriceOnKillo,prod.Technology,num);
                showTable.Items.Add(Info);
                num++;
            }
        
        }

        public void DeleteCurrentSelected()
        {
            var num = (Info)showTable.SelectedItem;
            MainWindow.Products.RemoveAt(num.Number-1);
            showTable.Items.RemoveAt(showTable.SelectedIndex);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteCurrentSelected();
        }
    }
}
