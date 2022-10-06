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
    /// Interaction logic for Expenses.xaml
    /// </summary>
    public partial class Expenses : Window
    {
        //Creating UserExp object
        UserExpenses myUserExp = new UserExpenses();

        public Expenses()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            //Creating MainWindow object
            MainWindow myMainWindow = new MainWindow();
            //Calling MainWindow class to show
            myMainWindow.Show();

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
                myUserExp.setIncome(Convert.ToDouble(txtBox_Income.Text));
                myUserExp.setGroceries(Convert.ToDouble(txtBox_Groceries.Text));
                myUserExp.setWaterAndElectricity(Convert.ToDouble(txtBox_WaterAndElectricity.Text));
                myUserExp.setTravelCosts(Convert.ToDouble(txtBox_TravelCosts.Text));
                myUserExp.setTeleCommunications(Convert.ToDouble(txtBox_Tele.Text));
                myUserExp.setOtherExpenses(Convert.ToDouble(txtBox_OtherExp.Text));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            myUserExp.setTax();

            //Displaying income
            MessageBox.Show("**********************************************************" + "\n" +
                                  "Gross Income: R" + myUserExp.getIncome() + "\n" +
                                  "****************************************************" + "\n" +
                                  "MONTHLY EXPENSES" + "\n" +
                                  "TAX : R" + myUserExp.getTax() + "\n" +
                                  "Groceries: R" + myUserExp.getGroceries() + "\n" +
                                  "Water And Electricity : R" + myUserExp.getWaterAndElectricity() + "\n" +
                                  "Travel Costs : R" + myUserExp.getTravelCosts() + "\n" +
                                  "Tele-Communications : R" + myUserExp.getTeleCommunications() + "\n" +
                                  "Other Expenses : R" + myUserExp.getOtherExpenses() + "\n" +
                                  "****************************************************"
                );

            //Creating HomeRentOrBuy object
            HomeRentOrBuy myHomeRentOrBuy = new HomeRentOrBuy();
            //Calling HomeRentOrBuy class to show
            myHomeRentOrBuy.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
