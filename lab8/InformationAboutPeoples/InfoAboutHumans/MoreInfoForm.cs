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
    /// <summary>
    /// MoreInfoForm class
    /// </summary>
    public partial class MoreInfoForm : Form
    {
        /// <summary>
        /// Create an istance of the MoreInfoForm
        /// </summary>
        /// <param name="humans"></param>
        public MoreInfoForm(List<Human> humans)
        {
            InitializeComponent();
            FunctionStudent(humans).ToString();

        }


        /// <summary>
        /// FunctionStudent
        /// </summary>
        /// <param name="humans">humans</param>
        /// <returns>counter</returns>

        int FunctionStudent(List<Human> humans)
        {
            humans = Reader.GetHuman();
            int counter = 0;
            string info = "";
            foreach (var hum in humans)
            {

                if (hum.Status == StatusOfHuman.Student)
                {
                    

                    if (hum.GetMoreInfo(hum.load) > 1)
                    {
                        info += hum.secondName + hum.ConvertToString(hum.load) + '\n';
                        counter++;
                    }
                    
                }
            }
            LabelInfo.Text = info;
            Count.Text = counter.ToString();

            return counter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
