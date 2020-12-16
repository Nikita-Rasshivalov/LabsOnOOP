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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public List<Student> Students { get; set; }
        public AddWindow(List<Student> Students)
        {
            this.Students = Students;
            InitializeComponent();


        }
        public Student CreateStudent()
        {
            string secondName = secondNamebox.Text;
            string firstName = firstNamebox.Text;
            string patronymic = patronymicbox.Text;
            Student student = new Student(firstName, secondName, patronymic);
            return student;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


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
