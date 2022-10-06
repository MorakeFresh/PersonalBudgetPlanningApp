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
    /// Interaction logic for HomeRent.xaml
    /// </summary>
    public partial class HomeRent : Window
    {
        UserExpenses myExp = new UserExpenses();
        
        public HomeRent()
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
            double inc = myExp.getIncome();

            try
            {
                myExp.setHomeRent(Convert.ToDouble(txtBox_HomeRent.Text));
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }


                //Displaying Accommodation rental report
                MessageBox.Show("***********************************************************************" + "\n" +
                                  "                        ACCOMMODATION RENTAL REPORT                    " + "\n" +
                                  "***********************************************************************" + "\n" +
                                  "***********************************************************************" + "\n" +
                                  "Monthly Rent = R" + myExp.getHomeRent() + "\n" +
                                  "***********************************************************************");
            

                
            //Creating VehicleRentOrBuy object
            VehicleRentOrBuy myVehicleRentOrBuy = new VehicleRentOrBuy();
            //Calling VehicleRentOrBuy window to show
            myVehicleRentOrBuy.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
