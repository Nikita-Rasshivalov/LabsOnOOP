using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoAboutHumans
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            DataGridView dataGridView1 = new DataGridView();
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            Funtcion(dataGridView1);
        }



        void Funtcion(DataGridView dataGridView1)
        {
            dataGridView1.Size = new Size(500, 280);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Second Name";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "second";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Years old";
            column2.Name = "birth";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Status";
            column3.Name = "status";
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




        }
    }
}
