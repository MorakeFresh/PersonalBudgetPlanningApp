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

namespace Final_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            //Closing window
            this.Close();
        }

        private void Btn_FAQ_Click(object sender, RoutedEventArgs e)
        {
            //Creating ReadMeFile object
            ReadMeFile myReadMeFile = new ReadMeFile();
            //Calling ReadMeFile class to show
            myReadMeFile.Show();

            //Hiding window
            this.Hide();
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            //Creating Expenses object
            Expenses myExpenses = new Expenses();
            //Calling Expenses class to 
            myExpenses.Show();

            //Hiding window
            this.Hide();
        }
    }
}
