using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Peoples;

namespace InfoAboutHumans
{
    /// <summary>
    /// class  MainForm
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// List humans
        /// </summary>
        public List<Human> Humans { get; set; }
        
        /// <summary>
        /// Create an istance of the MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Humans = Reader.GetHuman();
        }

        /// <summary>
        /// Show form button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowForm show = new ShowForm(Humans);

            show.ShowDialog();
        }
        /// <summary>
        /// Close this programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// More info button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MoreInfoForm more = new MoreInfoForm(Humans);
            more.ShowDialog();
        }
        /// <summary>
        /// Inform about teacher button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            TeacherInformationForm teach = new TeacherInformationForm(Humans);
            teach.ShowDialog();
        }

    }
}
