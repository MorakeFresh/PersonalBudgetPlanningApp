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

namespace Final_POE
{
    /// <summary>
    /// Interaction logic for HomeRentOrBuy.xaml
    /// </summary>
    public partial class HomeRentOrBuy : Window
    {
        public HomeRentOrBuy()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            //Creating Expenses object
            Expenses myExpenses = new Expenses();
            //Calling Expenses class to show
            myExpenses.Show();

            //Hiding window
            this.Hide();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            //Closing window
            this.Close();
        }

        private void Btn_Buy_Click(object sender, RoutedEventArgs e)
        {
            //Creating HomeLoan object
            HomeLoan myHomeLoan = new HomeLoan();
            //Calling HomeLoan class to show
            myHomeLoan.Show();

            //Hiding window
            this.Hide();
        }

        private void Btn_Rent_Click(object sender, RoutedEventArgs e)
        {
            //Creating HomeRent object
            HomeRent myHomeRent = new HomeRent();
            //Calling HomeRent class to show
            myHomeRent.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
