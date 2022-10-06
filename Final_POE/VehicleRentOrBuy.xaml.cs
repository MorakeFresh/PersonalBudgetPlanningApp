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
    /// Interaction logic for VehicleRentOrBuy.xaml
    /// </summary>
    public partial class VehicleRentOrBuy : Window
    {
        public VehicleRentOrBuy()
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

        private void Btn_Buy_Click(object sender, RoutedEventArgs e)
        {
            //Creating VehicleLoan object
            VehicleLoan myVehicleLoan = new VehicleLoan();
            //Calling VehicleLoan class to show
            myVehicleLoan.Show();

            //Hiding window
            this.Hide();
        }

        private void Btn_Rent_Click(object sender, RoutedEventArgs e)
        {
            //Creating VehicleRent object
            VehicleRent myVehicleRent = new VehicleRent();
            //Calling VehicleRent class to show
            myVehicleRent.Show();

            //Hiding window
            this.Hide();
        }

        
    }
}
