using Production;

using System.Windows;


namespace WpfAppForProduction
{
    /// <summary>
    /// Логика взаимодействия для ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        public ShowWindow()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CountVegetables.Content = 0;
            CountFruits.Content = 0;
            CountBerries.Content = 0;
            PriceNonEco.Content = 0;
            PriceEco.Content = 0;
            PriceEco.Content = 0;
            PriceNonEco.Content = 0;


            int countNonBerries = 0;
            int countNonFruits = 0;
            int countNonVegetables = 0;
            foreach (var prod in MainWindow.Products)
            {
                if (prod.Technology == false)
                {
                    if (prod.Type == ProdTypes.Berries)
                    {
                        countNonBerries++;

                    }
                    if (prod.Type == ProdTypes.Fruits)
                    {
                        countNonFruits++;
                    }
                    if (prod.Type == ProdTypes.Vegetables)
                    {
                        countNonVegetables++;
                    }

                }
              

            }
            CountVegetables.Content = countNonVegetables;
            CountFruits.Content = countNonFruits;
            CountBerries.Content = countNonBerries;



        }

    }
}
