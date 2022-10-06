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
    /// Interaction logic for HomeLoan.xaml
    /// </summary>
    public partial class HomeLoan : Window
    {
        UserExpenses myExps = new UserExpenses();

        public HomeLoan()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            //Creating Home rent or buy object
            HomeRentOrBuy myHomeRentOrBuy = new HomeRentOrBuy();
            //Calling Home rent or buy class to show
            myHomeRentOrBuy.Show();

            //Hiding window
            this.Hide();
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            //Closing window
            this.Close();
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                myExps.setHomePrice(Convert.ToDouble(txtBox_HomePrice.Text));
                myExps.setHomeDeposit(Convert.ToDouble(txtBox_HomeDeposit.Text));
                myExps.setHomeInterest(Convert.ToDouble(txtBox_HomeInterest.Text));
                myExps.setHomeMonths(Convert.ToDouble(txtBox_HomeMonths.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //Calling setHomeLoan method
            myExps.setHomeLoan();
            //Calling setHomeMonthlyRepayment method
            myExps.setHomeMonthlyRepayment();

            double inc = myExps.getIncome();

            //Declaring years variable
            double years = Math.Round(myExps.getHomeMonths() / 12, 2);

            //Displaying home loan report
            MessageBox.Show("****************************************************" + "\n" +
                "PROPERTY REPORT" + "\n" +
                "****************************************************" + "\n" +
                "Property Purchase Price= R" + myExps.getHomePrice() + "\n" +
                "Total Deposit = R" + myExps.getHomeDeposit() + "\n" +
                "Interest Rate = " + myExps.getHomeInterest() + "%" + "\n" +
                "Number of Months to pay = " + myExps.getHomeMonths() + " Months" + "\n" +
                "****************************************************" + "\n" +
                "****************************************************" + "\n" +
                "HOME LOAN REPORT" + inc +"\n" +
                "****************************************************" + "\n" +
                "Total Loan Repayment = R" + myExps.getHomeLoan() + "\n" +
                "Monthly Home Loan Repaymnet = R" + myExps.getHomeMonthlyRepayment() + "\n" +
                "Loan Duration = " + myExps.getHomeMonths() + " months" + " (" + years + " years)" + "\n" +
                "****************************************************") ;

            //Creating VehicleRentOrBuy object
            VehicleRentOrBuy myVehicleRentOrBuy = new VehicleRentOrBuy();
            //Calling VehicleRentOrBuy window to show
            myVehicleRentOrBuy.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
