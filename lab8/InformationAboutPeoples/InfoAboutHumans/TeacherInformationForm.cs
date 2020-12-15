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
    public partial class TeacherInformationForm : Form
    {
        public TeacherInformationForm(List<Human> humans)
        {
            InitializeComponent();
            Function(humans);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public  void Function(List<Human> humans) {
            string path = @"C:\Users\nikit\Desktop\OOP\LabsC#\lab8\InfoAboutPeoples.txt";
            humans = Reader.GetHuman(path);
            var teachersList = new List<Teacher>();
            foreach (var hum in humans)
            {
                if (hum.Status == StatusOfHuman.Teacher){
                    teachersList.Add((Teacher)hum);
                }
            }
            


            var maxOne = Teacher.MaxLoad(teachersList, "OOP");
            var maxTwo = Teacher.MaxLoad(teachersList, "Math");
            var maxThree = Teacher.MaxLoad(teachersList, "Physics");

            MessageBox.Show((teachersList.Count).ToString());

            if (comboBox1.SelectedIndex == 0)
            {
                InfoLabel.Text = maxOne.ToString();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                InfoLabel.Text = maxTwo.ToString();

            }
            if (comboBox1.SelectedIndex == 3)
            {
                InfoLabel.Text = maxThree.ToString();

            }




        }




    }
}
