using ShopFishing;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        static List<DayInfo> Purchases;
        public MainForm ()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdding add = new FormAdding();
            add.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
