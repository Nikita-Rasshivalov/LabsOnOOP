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
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        public ProductsWindow()
        {
            InitializeComponent();
            adding();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       void adding()
        {
            foreach (var prod in MainWindow.Products)
            {
                Info Info = new Info(prod.Type,prod.kind,prod.PriceOnKillo,prod.Technology);
                showTable.Items.Add(Info);
            }
        }
    }
}
