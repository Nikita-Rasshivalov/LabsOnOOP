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
using Exeptions;


namespace StudentsWPF
{
    /// <summary>
    /// Логика взаимодействия для ExamWindow.xaml
    /// </summary>
    public partial class ExamWindow : Window
    {
        public List<Exam> Names { get; set; }
        public ExamWindow(List<Exam> Names)
        {
            InitializeComponent();
            this.Names = Names;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int count = GetCount();
           
            try
            {
                if (count == 0)
                {
                    throw new NoValuesExeption("Count of exam can't be zero");
                }
                MainWindow.Flag = true;
                if (MainWindow.Flag == true)
                {
                    for (int i = 0; i < count; i++)
                    {
                        ExamNamesWindow name = new ExamNamesWindow(Names);
                        name.ShowDialog();
                    }
                }

                
            }
            catch (NoValuesExeption)
            {
                MessageBox.Show("Count of exam is zero!");
            }
            Close();


        }
        public int GetCount()
        {
            int CountExam;
            int.TryParse(NumExam.Text, out CountExam);
            MainWindow.NumOfExams = CountExam;
            return CountExam;
        }

        private void NumExam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
    }
}
