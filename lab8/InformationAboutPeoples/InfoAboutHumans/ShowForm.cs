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

    public partial class ShowForm : Form
    {
        public ShowForm(List<Human> humans)
        {
            DataGridView dataGridView1 = new DataGridView();
            InitializeComponent();
            this.Controls.Add(dataGridView1);
            Funtcion(dataGridView1, humans);
        }

        void Funtcion(DataGridView dataGridView1, List<Human> humans)
        {
            dataGridView1.Size = new Size(580, 300);
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
            column2.HeaderText = "Years old";
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
            string path = @"C:\Users\nikit\Desktop\OOP\LabsC#\lab8\InfoAboutPeoples.txt";
            dataGridView1.ReadOnly = true;
            humans = Reader.GetHuman(path);
        

            foreach (var hum in humans)
            {
                dataGridView1.Rows.Add(hum.secondName, hum.YearsOld, hum.status, hum.Loads);
                
            }

           
        


            










        }
    }
}
