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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Data = "";
        home homepage;
        

        public MainWindow()
        {
            InitializeComponent();
                       
        }

        public MainWindow(string data)
        {
            this.Data = data;
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (homepage == null)
            {
                homepage = new home(Data);
            }
            frm.Navigate(new home(Data));
            //frm.Navigate(new Uri("home.xaml", UriKind.Relative));
        }
        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {

            frm.Navigate(new Uri("HistoryPage.xaml", UriKind.Relative));
        }
        private void BookMarkButton_Click(object sender, RoutedEventArgs e)
        {

            frm.Navigate(new Uri("BookMarkPage.xaml", UriKind.Relative));
        }

        private void on_loaded(object sender, RoutedEventArgs e)
        {
            
            if (homepage == null)
                {
                   homepage = new home(Data);
                }
                frm.Navigate(new home(Data));
                //frm.Navigate(new Uri("home.xaml", UriKind.Relative));
        }
       

    }
}

