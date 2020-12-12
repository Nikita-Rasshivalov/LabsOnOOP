using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Peoples;

namespace InfoAboutHumans
{
    public partial class MainForm : Form
    {
        List<Human> humans = new List<Human>();



        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {

           
         

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

        private void button1_Click(object sender, EventArgs e)
        {
            ShowForm show = new ShowForm();
            show.ShowDialog();

        
        }
    }
}
