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
    /// Interaction logic for VehicleRent.xaml
    /// </summary>
    public partial class VehicleRent : Window
    {
        UserExpenses myExpn = new UserExpenses();

        public VehicleRent()
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
                myExpn.setModelAndMake(Convert.ToString(txtBox_ModelAndMake.Text));
                myExpn.setVehicleRent(Convert.ToDouble(txtBox_VehicleRent.Text));
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            //Displaying vehicle rental report
            MessageBox.Show("***********************************************************************" + "\n" +
                                  "                        VEHICLE RENTAL REPORT                    " + "\n" +
                                  "***********************************************************************" + "\n" +
                                  "***********************************************************************" + "\n" +
                                  "Vehicle Model & Make - " + myExpn.getModelAndMake() + "\n" +
                                  "Monthly Rent = R" + myExpn.getVehicleRent() + "\n" +
                                  "***********************************************************************");

            //Creating Savings object
            Savings mySavings = new Savings();
            //Calling Savings class to show
            mySavings.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
