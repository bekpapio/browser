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
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Page
    {
        private string data;
        string url;



        public home()
        {
            InitializeComponent();
            bkbtn.IsEnabled = true;
            frdbtn.IsEnabled = true;

        }

        public home(string data)
        {
            this.data = data;
            InitializeComponent();
            bkbtn.IsEnabled = true;
            frdbtn.IsEnabled = true;

        }

       

        private void Bkbtn_Click(object sender, RoutedEventArgs e)
        {
            try
           {
                browser.GoBack();
            } catch (Exception )
            {

                bkbtn.IsEnabled = false;
                
            }

           
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            
            url= search.Text.ToLower();
            if (url.Contains("https://") && url.Contains("."))
            {
                url = search.Text;
            }
            else if (!url.Contains("https://") || url.Contains("."))
            {
                url = "https://" + search.Text;
            }
            
                browser.Navigate(url);

            HistoryImpl histt = new HistoryImpl();
            HistoryDataBaseT hist = new HistoryDataBaseT
            {
                Query = url, 
                Date = DateTime.Now
            };

            histt.Save(hist);

            

        }

        private void frdbtn_click(object sender, RoutedEventArgs e)
        {
            try
            {
                browser.GoForward();
            }
            catch (Exception )
            {
                frdbtn.IsEnabled = false;
                //MessageBox.Show("you have reached the last page", "Exception");
            }
            
        }

        

        private void onPageLoad(object sender, RoutedEventArgs e)
        {
            if(data.ToString() == "")
            {
                search.Text = "";
               
            }
            else
            {
                search.Text = data.ToString();
            }
            
        }

        private void Bokbtn_Click(object sender, RoutedEventArgs e)
        {
            BookMarkImpl bokk = new BookMarkImpl();
            BookMarkDatabaseT BookM = new BookMarkDatabaseT
            {
                Query = search.Text,
                Date = DateTime.Now
            };

            bokk.Save(BookM);
            
        }
    }
}
