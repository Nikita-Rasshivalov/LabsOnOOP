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
using Students;
namespace StudentsWPF
{

    public partial class ListExams : Window
    {
        Student Stud { get; set; }
        public List<Exam> Names { get; set; }
        public ListExams(List<Exam> names, Student stud)
        {
            this.Stud = stud;
            this.Names = names;
            InitializeComponent();
            GetNames(Names);
        }

        void GetNames(List<Exam>  names)
        {
            
            
            foreach (var exam in names)
            {
                CheckBox check = new CheckBox();
                check.Content = exam.NameOfExam;
                ExamBox.Items.Add(check);
            } 

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddExams();
        }

        void AddExams()
        {
            if (Stud.Marks == null)
            {
                Stud.Marks = new List<StudentMark>();
            }
            foreach (var item in ExamBox.Items)
            {
                CheckBox checkBox = (CheckBox)item;


                if (checkBox.IsChecked == true)
                {
                    StudentMark exam = new StudentMark(new Exam(checkBox.Content.ToString()), 0);
                    Stud.Marks.Add(exam);
                    MessageBox.Show("Exams was added");
                }
            }
        }
    }

   

}
