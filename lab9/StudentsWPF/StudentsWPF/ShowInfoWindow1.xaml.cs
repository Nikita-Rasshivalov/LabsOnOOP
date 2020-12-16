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
        DataGrid dataGrid1 { get; set; }
        public List<Exam> Names { get; set; }
        public ShowInfoWindow1(List<Exam> Names)
        {
            this.Names = Names;
            DataGrid dataGrid1 = new DataGrid();
            this.dataGrid1 = dataGrid1;
            InitializeComponent();
            FuntcionAddTable(Names);
            
           
        }
        /// <summary>
        ///Function of drawing the table
        /// </summary>
        void FuntcionAddTable(List<Exam> Names)
        {

            DataGridTextColumn textColumn = new DataGridTextColumn();
            textColumn.Header = "First Name";
            textColumn.Binding = new Binding("FirstName");
            dataGrid1.Columns.Add(textColumn);



        }
        
        private void Button_ClickClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
