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
    /// Логика взаимодействия для ExamNamesWindow.xaml
    /// </summary>
    public partial class ExamNamesWindow : Window
    {
        public List<Exam> Names { get; set; }
        public ExamNamesWindow(List<Exam> Names)
        {
            InitializeComponent();
            this.Names = Names;
        }



        public Exam GetNameOfExam()
        {
            string name = NameBox.Text;

            Exam exam = new Exam(name);
         
            return exam;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Exam name = GetNameOfExam();
            Names.Add(name);
        }
    }
}
