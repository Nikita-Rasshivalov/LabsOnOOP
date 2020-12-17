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
    /// Логика взаимодействия для ShowInfoWindow1.xaml
    /// </summary>
    public partial class ShowInfoWindow1 : Window
    {
        protected List<int[]> Marks { get; set; }
        protected List<Exam> Names { get; set; }
        protected List<Student> Students { get; set; }
        public ShowInfoWindow1(List<Exam> names, List<Student> students)
        {
           // names = new List<Exam>(3) { new Exam("OOP"), new Exam("Math"), new Exam("OAIP") };
           //students = new List<Student>(3) { new Student("Ivan", "Dubikov", "GGG"), new Student("Artom", "NeDubiliv", "GGG"), new Student("Nikita", "Dubikov", "GGG") };
          //  Marks = new List<int[]>(3) { new int[3] { 10, 9, 8 }, new int[3] { 10, 9, 8 }, new int[3] { 10, 9, 8 } };
            this.Names = names;
            this.Students = students;
            FillExamNames();
            InitializeComponent();
            FillTable();
        }
        private void FillExamNames()
        {
            foreach (var student in Students)
            {
                student.Marks = new StudentMark[Names.Count];
                for (var i = 0; i < student.Marks.Length; i++)
                {
                    student.Marks[i] = new StudentMark(Names[i], 0);
                }
            }
        }
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        private void FillTable()
        {
            for (var i = 0; i < Marks[0].Length; i++)
            {
                var textColumn = new DataGridTextColumn();
                textColumn.Header = Names[i].NameOfExam;
                textColumn.Binding = new Binding(string.Format($"[{i}]"));
                marksTable.Columns.Add(textColumn);
            }
            marksTable.ItemsSource = Marks;
            showTable.ItemsSource = Students;
        }

        private void Button_ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SendInfo_Click(object sender, RoutedEventArgs e)
        {
            bool isCorrect = true;
            for (var i = 0; i < Students.Count && isCorrect == true; i++)
            {
                for (var j = 0; j < Students[i].Marks.Length && isCorrect == true; j++)
                {
                    MessageBox.Show($"{i} {j} {Students[i].Marks.Length}");
                    if (Marks[i][j] >= 1 && Marks[i][j] <= 10)
                    {
                        Students[i].Marks[j].Mark = Marks[i][j];
                    }
                    else
                    {
                        isCorrect = false;
                    }
                }
            }
            string message;
            if (isCorrect == true)
            {
                message = "Marks succesfull have been added!";
            }
            else
            {
                message = "Incorrect marks";
            }
            MessageBox.Show(message);
            this.Close();
        }
    }
}
