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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sample
{
    /// <summary>
    /// Interaction logic for BookMarkPage.xaml
    /// </summary>
    public partial class BookMarkPage : Page
    {
        public string Data { get; set; }
        public BookMarkPage()
        {
            InitializeComponent();
        }


        private void on_load(object sender, RoutedEventArgs e)
        {
            BookMarkImpl BookM = new BookMarkImpl();
            var records = BookM.GetList();
            histDataGrid.ItemsSource = records;

        }

        private void delet_clicked(object sender, RoutedEventArgs e)
        {
            BookMarkImpl bokk = new BookMarkImpl();
            BookMarkDatabaseT doble = histDataGrid.SelectedItem as BookMarkDatabaseT;
            int id = doble.Id;
            bokk.Delete(id);

            
            var records = bokk.GetList();
            histDataGrid.ItemsSource = records;

        }


        private void on_double(object sender, MouseButtonEventArgs e)
        {
            

            BookMarkDatabaseT doble = histDataGrid.SelectedItem as BookMarkDatabaseT;
            Data = doble.Query;
            
            MainWindow x = new MainWindow(Data);

            MainWindow main = Application.Current.MainWindow as MainWindow;
           
            x.Show();
            if (main != null)
            {

                main.Close();
            }
            



        }

        private void Clrbtn_Click(object sender, RoutedEventArgs e)
        {
            BookMarkImpl bokk = new BookMarkImpl();
            bokk.DeleteAll();

            var records = bokk.GetList();
            histDataGrid.ItemsSource = records;



        }
    }
}
