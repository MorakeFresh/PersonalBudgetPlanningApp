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
    /// Interaction logic for VehicleLoan.xaml
    /// </summary>
    public partial class VehicleLoan : Window
    {
        UserExpenses myExpns = new UserExpenses();

        public VehicleLoan()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            //Creating Vehicle rent or buy object
            VehicleRentOrBuy myVehicleRentOrBuy = new VehicleRentOrBuy();
            //Calling Vehicle rent or buy class to show
            myVehicleRentOrBuy.Show();

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
                myExpns.setModelAndMake(Convert.ToString(txtBox_ModelAndMake.Text));
                myExpns.setVehiclePrice(Convert.ToDouble(txtBox_VehiclePrice.Text));
                myExpns.setVehicleDeposit(Convert.ToDouble(txtBox_VehicleDeposit.Text));
                myExpns.setVehicleInterest(Convert.ToDouble(txtBox_VehicleInterest.Text));
                myExpns.setVehicleInsurance(Convert.ToDouble(txtBox_VehicleInsurance.Text));

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            //Calling setVehicleLoan method
            myExpns.setVehicleLoan();
            //Calling setVehicleMonthlyRepayment method
            myExpns.setVehicleMonthlyRepayment();

            //Displaying report
            MessageBox.Show("****************************************************" + "\n" +
               "VEHICLE REPORT" + "\n" +
               "****************************************************" + "\n" +
               "Vehicle Model & Make - " + myExpns.getModelAndMake() + "\n" +
               "Vehicle Purchase Price= R" + myExpns.getVehiclePrice() + "\n" +
               "Total Deposit = R" + myExpns.getVehicleDeposit() + "\n" +
               "Interest Rate = " + myExpns.getVehicleInterest() + "%" + "\n" +
               "Insurance Premium = " + myExpns.getVehicleInsurance() + " Months" + "\n" +
               "****************************************************" + "\n" +
               "****************************************************" + "\n" +
               "VEHICLE LOAN REPORT" + "\n" +
               "****************************************************" + "\n" +
               "Total Loan Repayment = R" + myExpns.getVehicleLoan() + "\n" +
               "Monthly loan Repayment = R" + myExpns.getVehicleMonthlyRepayment() + " Including Insurnce" + "\n" +
               "Loan Duration = " + 60 + " months" + " (" + 5 + " years)" + "\n" +
               "****************************************************");

            //Creating Savings object
            Savings mySavings = new Savings();
            //Calling Savings class to show
            mySavings.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
