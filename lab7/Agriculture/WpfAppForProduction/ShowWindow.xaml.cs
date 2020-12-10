using Production;

using System.Windows;


namespace WpfAppForProduction
{
    /// <summary>
    /// Логика взаимодействия для ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        /// <summary>
        ///  Creates an instance of the ShowWindow class
        /// </summary>
        public ShowWindow()
        {
            InitializeComponent();
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
        /// Show information about products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            calcAverage();
        }

        /// <summary>
        /// average eco and not eco production
        /// </summary>
        void calcAverage()
        {

            if (Kindbox.SelectedIndex == 0 )
            {
                   
                PriceEco.Content = InfoAboutProduction.GetAverageEco(MainWindow.Products, ProdTypes.Fruits);
                PriceNonEco.Content = InfoAboutProduction.GetAverageNoEco(MainWindow.Products, ProdTypes.Fruits);

            }

            if (Kindbox.SelectedIndex == 1)
            {
                PriceEco.Content = InfoAboutProduction.GetAverageEco(MainWindow.Products, ProdTypes.Vegetables);
                PriceNonEco.Content = InfoAboutProduction.GetAverageNoEco(MainWindow.Products, ProdTypes.Vegetables);

            }
            if (Kindbox.SelectedIndex == 2)
            {
                PriceEco.Content= InfoAboutProduction.GetAverageEco(MainWindow.Products, ProdTypes.Berries);
                PriceNonEco.Content = InfoAboutProduction.GetAverageNoEco(MainWindow.Products, ProdTypes.Berries);

            }




        }
    }
}
