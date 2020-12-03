using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    /// <summary>
    /// Class of showing information
    /// </summary>
    public partial class ShowInfoForm : Form
    {
        /// <summary>
        /// Creates an instance of the Show class
        /// </summary>
        public ShowInfoForm()
        {
            DataGridView dataGridView1 = new DataGridView();
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            Funtcion(dataGridView1);
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
        ///Function of drawing the table
        /// </summary>
        void Funtcion(DataGridView dataGridView1)
        {
            dataGridView1.Size = new Size(500, 280);
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            

      var column1 = new DataGridViewColumn();
            column1.HeaderText = "Kind"; 
            column1.Width = 100; 
            column1.ReadOnly = true; 
            column1.Name = "kind"; 
            column1.Frozen = true; 
            column1.CellTemplate = new DataGridViewTextBoxCell(); 

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Type";
            column2.Name = "type";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Price BYN";
            column3.Name = "price";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Data";
            column4.Name = "data";
            column4.Width = 150;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            


            foreach (var day in MainForm.Purchases)
            {
                foreach (var pur in day.Purchases)
                {
                    dataGridView1.Rows.Add( pur.ThingType, pur.FishingType, pur.Price,pur.Date.ToString("dd.MM.yyyy"));
                }
              
            }
        }
        /// <summary>
        /// Show more information button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Average_Click(object sender, EventArgs e)
        {
            MoreInfForm average = new MoreInfForm();
            average.Show();
        }
    }
}
