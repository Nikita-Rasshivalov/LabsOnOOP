﻿using Peoples;
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
            Count.Text = FunctionStudent(humans).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        int FunctionStudent(List<Human> humans)
        {
            string path = @"C:\Users\nikit\Desktop\OOP\LabsC#\lab8\InfoAboutPeoples.txt";
            humans = Reader.GetHuman(path);
            int counter = 0;
            string loads = "";



            //loads = hum.ConvertToString(hum.load);
            foreach (var hum in humans)
            {
                


                if (hum.Status == StatusOfHuman.Student)
                {

                    if (hum.GetMoreInfo(hum.load)>2)
                    {
                        counter++;
                    }
                 
                    //counter = hum.GetMoreInfo(hum.load);
                    
                }





            }
            MessageBox.Show(counter.ToString());

            return counter;
        }


    }
}
