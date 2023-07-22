using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sample
{
    /// <summary>
    /// Interaction logic for HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        
        public string Data { get; set; }
        
        public HistoryPage()
        {
            InitializeComponent();
        }

        private void on_load(object sender, RoutedEventArgs e)
        {
            HistoryImpl histt = new HistoryImpl();
            var records=histt.GetList();
            histDataGrid.ItemsSource = records;

        }

        private void delet_clicked(object sender, RoutedEventArgs e)
        {
            HistoryImpl histt = new HistoryImpl();
            HistoryDataBaseT doble = histDataGrid.SelectedItem as HistoryDataBaseT;
            int id = doble.Id;
            histt.Delete(id);

            
            var records = histt.GetList();
            histDataGrid.ItemsSource = records;




        }

        
        private void on_double(object sender, MouseButtonEventArgs e)
        {
           

             HistoryDataBaseT doble = histDataGrid.SelectedItem as HistoryDataBaseT;
            Data = doble.Query;
            
            MainWindow x = new MainWindow(Data);
            
            
            x.Show();
                      

            
            MainWindow main = Application.Current.MainWindow as MainWindow;
            if (main != null)
            {
               
                main.Close();
            }


        }

       

        private void Clrbtn_Click(object sender, RoutedEventArgs e)
        {
            HistoryImpl histt = new HistoryImpl();
            histt.DeleteAll();

            var records = histt.GetList();
            histDataGrid.ItemsSource = records;


        }
    }
}
