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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public Savings()
        {
            InitializeComponent();
        }

        //Declaring goal variable
        protected string goal;
        //Declaring savingsAmount variable
        protected double savingsAmount;
        //Declaring monthlySavings variable
        protected double monthlySavings;

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

        //Creating getGoal method
        public string getGoal()
        {
            return goal;
        }
        private void txtBox_Goal_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                goal = txtBox_Goal.Text;
                this.goal = goal;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //Creating getSavingsAmount method
        public double getSavingsAmount()
        {
            return savingsAmount;
        }
        private void txtBox_SavingsAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                savingsAmount = Convert.ToInt32(txtBox_SavingsAmount.Text);
                this.savingsAmount = savingsAmount;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Btn_1Year_Click(object sender, RoutedEventArgs e)
        {
            double interest = 0.05;
            double years = 1;

            //Calculating monthlySavings
            monthlySavings = Math.Round((savingsAmount * (interest / 12)) / (Math.Pow((1 + (interest / 12)), years * 12) - 1), 2);
        }

        private void Btn_2Years_Click(object sender, RoutedEventArgs e)
        {
            double interest = 0.10;
            double years = 2;

            //Calculating monthlySavings
            monthlySavings = Math.Round((savingsAmount * (interest / 12)) / (Math.Pow((1 + (interest / 12)), years * 12) - 1), 2);
        }

        private void Btn_3Years_Click(object sender, RoutedEventArgs e)
        {
            double interest = 0.15;
            double years = 3;

            //Calculating monthlySavings
            monthlySavings = Math.Round((savingsAmount * (interest / 12)) / (Math.Pow((1 + (interest / 12)), years * 12) - 1), 2);
        }

        private void Btn_4Years_Click(object sender, RoutedEventArgs e)
        {
            double interest = 0.20;
            double years = 4;

            //Calculating monthlySavings
            monthlySavings = Math.Round((savingsAmount * (interest / 12)) / (Math.Pow((1 + (interest / 12)), years * 12) - 1), 2);
        }

        private void Btn_5Years_Click(object sender, RoutedEventArgs e)
        {
            double interest = 0.25;
            double years = 5;

            //Calculating monthlySavings
            monthlySavings = Math.Round((savingsAmount * (interest / 12)) / (Math.Pow((1 + (interest / 12)), years * 12) - 1), 2);
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            //Dispaying savings report
            MessageBox.Show("****************************************************" + "\n" +
               "SAVINGS REPORT" + "\n" +
               "****************************************************" + "\n" +
               "To reach your goal of : " + goal + "\n" +
               "You have to save " + monthlySavings + " every month for the selected period");
            //Displaying thank you message
            MessageBox.Show("THANK YOU FOR YOU USING THE LOANS APPLICATION");

            //Closing window
            this.Close();
        }

        
    }
}
