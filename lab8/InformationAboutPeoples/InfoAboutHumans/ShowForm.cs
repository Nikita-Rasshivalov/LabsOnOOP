using Peoples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;
using ColorConverter = System.Drawing.ColorConverter;

namespace InfoAboutHumans
{
    /// <summary>
    /// Class ShowForm
    /// </summary>
    public partial class ShowForm : Form
    {
        public List<Human> humans { get; set; }
        private DataGridView dataGridView1 { get; set; }
        /// <summary>
        /// ShowForm
        /// </summary>
        /// <param name="humans">humans</param>
        public ShowForm(List<Human> humans)
        {
            DataGridView dataGridView1 = new DataGridView();
            this.dataGridView1=dataGridView1;
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            this.humans = humans;
            Funtcion( humans);
        }
        /// <summary>
        /// Create table
        /// </summary>
        /// <param name="dataGridView1">dataGridView1</param>
        /// <param name="humans">humans</param>
        void Funtcion(List<Human> humans)
        {
            dataGridView1.Size = new Size(580, 290);
            dataGridView1.RowHeadersVisible = false;
            
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Second Name";
            column1.Width = 120;
            column1.ReadOnly = true;
            column1.Name = "second";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Birth";
            column2.Name = "birth";
            column2.Width = 120;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Status";
            column3.Name = "status";
            column3.Width = 120;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Data";
            column4.Name = "data";
            column4.Width = 200;
            column4.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.ReadOnly = true;
            humans.Sort();
            foreach (var hum in humans)
            {
                dataGridView1.Rows.Add(hum.secondName, hum.birth,hum.Status, hum.Loads);  
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
           
                if (DateTime.Now.Year - Convert.ToInt32(row.Cells[1].Value ) > 19 &&  row.Cells[2].Value.ToString() == "Student")
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            FunctionDelete(humans);
        }
        public void FunctionDelete( List<Human> humans )
        {
         
            int selectedIndex = dataGridView1.CurrentRow.Index; 
            dataGridView1.Rows.RemoveAt(selectedIndex);
            humans.RemoveAt(selectedIndex); 

            //MessageBox.Show("Human was deleted");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
