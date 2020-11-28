using ShopFishing;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    /// <summary>
    /// The class representing a form that implements the interface of the application menu
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// List of purchases
        /// </summary>
        public static List<DayInfo> Purchases;

        /// <summary>
        /// Creates an instance of the Main class
        /// </summary>
        public MainForm ()
        {
            InitializeComponent();
            Purchases = new List<DayInfo>();
            
        }
        /// <summary>
        /// Open window of adding information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.Show();

        }

        /// <summary>
        /// Open window of edit information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            ShowInfoForm show = new ShowInfoForm();
            show.Show();
        }

        /// <summary>
        /// Open window of edit information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void EditButton_Click_1(object sender, EventArgs e)
        {
            EditForm edit = new EditForm();
            edit.Show();
        }

        /// <summary>
        /// Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Open window of information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            InformationAboutPeriodForm info = new InformationAboutPeriodForm();
            info.Show();
        }


        
    }


}
