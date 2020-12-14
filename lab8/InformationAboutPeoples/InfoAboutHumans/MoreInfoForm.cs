using Peoples;
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
    public partial class MoreInfoForm : Form
    {
        public MoreInfoForm(List<Human> humans)
        {
            InitializeComponent();
            Function(humans);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void Function(List<Human> humans)
        {

        }
    }
}
