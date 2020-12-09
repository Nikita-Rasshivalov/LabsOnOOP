using System;
using System.Windows;
using System.Windows.Controls;
using System.Text;
using Production;


namespace WpfAppForProduction
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {

        public AddWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox0.SelectedIndex == 1)
            {
                ComboBox1.Items.Clear();
                ComboBox1.Items.Add("Apples");
                ComboBox1.Items.Add("Apricots");
                ComboBox1.Items.Add("Kiwis");
                ComboBox1.Items.Add("Lemons");
                ComboBox1.Items.Add("Oranges");
                ComboBox1.Items.Add("Pears");
                ComboBox1.Items.Add("Peachs");
                ComboBox1.Items.Add("Tangerines");
                ComboBox1.Items.Add("Mandarines");
                ComboBox1.Items.Add("Banans");
            }
            if (ComboBox0.SelectedIndex == 0)
            {
                ComboBox1.Items.Clear();
                ComboBox1.Items.Add("Bluberries");
                ComboBox1.Items.Add("Grapes");
                ComboBox1.Items.Add("Strawberries");
                ComboBox1.Items.Add("Blackberries");
                ComboBox1.Items.Add("Barberries");
                ComboBox1.Items.Add("Watermelons");
                ComboBox1.Items.Add("Melons");
                ComboBox1.Items.Add("Cranberries");
                ComboBox1.Items.Add("Raspberries");
                ComboBox1.Items.Add("Lingonberries");
            }
            if (ComboBox0.SelectedIndex == 2)
            {
                ComboBox1.Items.Clear();
                ComboBox1.Items.Add("Carrots");
                ComboBox1.Items.Add("Potatos");
                ComboBox1.Items.Add("Peppers");
                ComboBox1.Items.Add("Tomatos");
                ComboBox1.Items.Add("Squashs");
                ComboBox1.Items.Add("Cabbages");
                ComboBox1.Items.Add("Melons");
                ComboBox1.Items.Add("Cucumbers");
                ComboBox1.Items.Add("Pumpkins");
                ComboBox1.Items.Add("Spinachs");
            }

        }

        private void PriceBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

            e.Handled = !(Char.IsDigit(e.Text, 0));
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int price;
            ProdTypes type;
            bool technology;
            Enum.TryParse(ComboBox0.Text, out type);
            int.TryParse(PriceBox.Text, out price);
            string kind = ComboBox1.Text;

            PriceBox.Text = "";
            InfoAboutProduction product = null;
            if (ComboBox2.SelectedIndex == 0)
            {
                technology = true;
            }
            else
            {
                technology = false;
            }
            switch (type)
            {
                case ProdTypes.Fruits:
                    product = new Fruits(price, kind, technology);
                    break;
                case ProdTypes.Vegetables:
                    product = new Vegetables(price, kind, technology);
                    break;
                case ProdTypes.Berries:
                    product = new Berries(price, kind, technology);
                    break;
                default:
                    break;

            }
            if (price == 0)
            {
                MessageBox.Show("Product wasn't added, enter price.", "Information");
            }
            else
            {
                MainWindow.Products.Add(product);
                MessageBox.Show("Product was added","Information");
            }
            ComboBox0.SelectedIndex = 0;
            ComboBox1.SelectedIndex = 0;
            ComboBox2.SelectedIndex = 0;
        }


    }
}
