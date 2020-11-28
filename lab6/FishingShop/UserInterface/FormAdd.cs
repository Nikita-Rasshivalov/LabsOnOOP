using System;
using System.Windows.Forms;
using ShopFishing;

namespace UserInterface
{
    public partial class FormAdd : Form
    {
        /// <summary>
        /// Creates an instance of the InformationAboutPeriodForm class
        /// </summary>
        public FormAdd()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adding information button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int price;
            FishingThings type;
            Enum.TryParse(comboBox1.Text, out type);
            FishingType typeSeason;
            Enum.TryParse(comboBox2.Text, out typeSeason);
            int.TryParse(PriceBox.Text, out price);
            DateTime date = dateTimePicker1.Value;
            DayInfo.InfoAboutPurchase p = new DayInfo.InfoAboutPurchase(type, date, typeSeason, price);
            DayInfo.AddThings(MainForm.Purchases, p);
            string message = "The purchase was added";
            string caption = "Addition result";
            MessageBoxIcon icon = MessageBoxIcon.None;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons, icon);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            PriceBox.Text = "";

        }

        /// <summary>
        /// Returns to the main form by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Chesck input(Enter numbers and backspase)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

       
    }
}
