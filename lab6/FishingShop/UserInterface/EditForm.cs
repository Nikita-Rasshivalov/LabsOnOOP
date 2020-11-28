using ShopFishing;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    /// <summary>
    /// The class for edit a data
    /// </summary>
    public partial class EditForm : Form
    {
        /// <summary>
        /// Link to the main form
        /// </summary>
        /// 

        /// <summary>
        /// Creates an instance of the EditForm class
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Returns to the main form by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clears the all data by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Allbtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Delete confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            
            if (result == DialogResult.Yes)
            {
                MainForm.Purchases.Clear();
       
                message = "All data has been deleted";
                caption = "Operation result";
                icon = MessageBoxIcon.Information;
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, icon);
            }
        }

        /// <summary>
        /// Clears the data of period by clicking the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnClear_Click(object sender, EventArgs e)
        {
            string message = "Are you sure?";
            string caption = "Delete confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                DateTime date = SelectedDate.Value;
                DayInfo pur = MainForm.Purchases.Find(x => x.Date.Date == date.Date);
                MainForm.Purchases.Remove(pur);
                message = "The day was deleted";
                caption = "Operation result";
                icon = MessageBoxIcon.Information;
                buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, icon);
            }
        }
    }
}
