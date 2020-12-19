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
    /// <summary>
    /// class ListExams
    /// </summary>
    public partial class ListExams : Window
    {
        /// <summary>
        /// Student
        /// </summary>
        Student Stud { get; set; }
        /// <summary>
        /// List names
        /// </summary>
        public List<Exam> Names { get; set; }


        /// <summary>
        /// Create ListExams
        /// </summary>
        /// <param name="names"></param>
        /// <param name="stud"></param>
        public ListExams(List<Exam> names, Student stud)
        {
            this.Stud = stud;
            this.Names = names;
            InitializeComponent();
            GetNames(Names);
        }
        /// <summary>
        /// Get names
        /// </summary>
        /// <param name="names">names</param>
        void GetNames(List<Exam>  names)
        {
            
            foreach (var exam in names)
            {
                CheckBox check = new CheckBox();
                check.Content = exam.NameOfExam;
                ExamBox.Items.Add(check);
            } 

        }
        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Add exams buttom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddExams();
        }
        /// <summary>
        /// Add exams
        /// </summary>
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
                    
                }
            }
            MessageBox.Show("Exams was added");
            Close();
        }
    }

   

}
