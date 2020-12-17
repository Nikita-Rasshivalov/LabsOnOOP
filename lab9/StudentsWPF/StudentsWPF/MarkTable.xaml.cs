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
    /// Логика взаимодействия для MarkTable.xaml
    /// </summary>
    public partial class MarkTable : Window
    {
        /// <summary>
        /// List names of exams
        /// </summary>
        public List<Exam> Names { get; set; }
        /// <summary>
        /// Array of marks
        /// </summary>
        public StudentMark[] Marks { get; set ;}
        /// <summary>
        /// Create MarkTable
        /// </summary>
        /// <param name="Marks"></param>
        public MarkTable(StudentMark[] Marks, List<Exam> Names)
        {
            this.Names = Names;
            this.Marks = Marks;
            InitializeComponent();
            FuntcionAddTable(Marks, Names);
        }

        /// <summary>
        ///Function of drawing the table
        /// </summary>
        void FuntcionAddTable(StudentMark[] Marks, List<Exam> Names)
        {
            showTableTwo.ItemsSource = Names;
            
           

        }
        /// <summary>
        /// close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Close();
        }
    }
}
