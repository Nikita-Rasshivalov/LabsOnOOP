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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public static List<InfoAboutProduction> Products = new List<InfoAboutProduction>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow();
            add.ShowDialog();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            ShowWindow show = new ShowWindow();
            show.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProductsWindow prod = new ProductsWindow();
            prod.ShowDialog();
        }
    }
}
