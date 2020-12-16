using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentsWPF
{
    /// <summary>
    /// Class AddWindow
    /// </summary>
    public partial class AddWindow : Window
    {
        /// <summary>
        /// Students list
        /// </summary>
        public List<Student> Students { get; set; }
        /// <summary>
        /// Create AddWindow
        /// </summary>
        /// <param name="Students">Students</param>
        public AddWindow(List<Student> Students)
        {
            this.Students = Students;
            InitializeComponent();


        }
        /// <summary>
        /// Create student
        /// </summary>
        /// <returns>student</returns>
        public Student CreateStudent()
        {
            string secondName = secondNamebox.Text;
            string firstName = firstNamebox.Text;
            string patronymic = patronymicbox.Text;
            Student student = new Student(firstName, secondName, patronymic);
            return student;
        }


        /// <summary>
        /// Close this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Add student button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddButtom_Click(object sender, RoutedEventArgs e)
        {
            Student student = CreateStudent();
            Students.Add(student);
            MessageBox.Show("Student was added");
            secondNamebox.Text = "";
            firstNamebox.Text = "";
            patronymicbox.Text = "";
        }
    }
}
