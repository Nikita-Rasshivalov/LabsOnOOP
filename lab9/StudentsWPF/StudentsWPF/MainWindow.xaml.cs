using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Students;

namespace StudentsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Student> Students { get; set; }

        public List<Exam> Names { get; set; }


        public static bool Flag { get; set; }
        public static int NumOfExams;

        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>();
            Names = new List<Exam>();

        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            AddWindow add = new AddWindow(Students);
            add.ShowDialog();
        }

       
        private void Button_Show(object sender, RoutedEventArgs e)
        {
            ShowInfoWindow1 add = new ShowInfoWindow1(Names);
            add.ShowDialog();
        }

        private void Add_Exams_Click(object sender, RoutedEventArgs e)
        {
            if (Flag == false)
            {
                ExamWindow exam = new ExamWindow(Names);

                exam.ShowDialog();
            }
            else
            {
                MessageBox.Show("Exams have been added");
            }
           

        }
    }
}
