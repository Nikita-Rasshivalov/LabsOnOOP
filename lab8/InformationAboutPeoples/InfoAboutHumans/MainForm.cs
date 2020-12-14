using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Peoples;

namespace InfoAboutHumans
{
    public partial class MainForm : Form
    {
        public List<Human> humans = new List<Human>();



        public MainForm()
        {
            InitializeComponent();

        }





        private static List<string> GetData()
        {
            List<string> data = new List<string>();
            string path = @"C:\Users\nikit\Desktop\OOP\LabsC#\lab8\InfoAboutPeoples.txt";
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    data.Add(sr.ReadLine());
                }
            }
            return data;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowForm show = new ShowForm(humans);

            show.ShowDialog();
        }
    }
}
