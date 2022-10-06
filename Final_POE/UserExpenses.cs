using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POE
{
    class UserExpenses
    {
        //Declaring income variable
        private double income;
        //Declaring tax variable
        private double tax;
        //Declaring groceries variable
        private double groceries;
        //Declaring waterAndElectricity variable
        private double waterAndElectricity;
        //Declaring travelCosts variable
        private double travelCosts;
        //Declaring teleCommunications variable
        private double teleCommunications;
        //Declaring otherExpenses variable
        private double otherExpenses;
        //Declaring Exp list variable
        private List<double> Exp;
        //Declaring totalExpenses variable
        private double totalExpenses;

        //Creating setIncome method
        public void setIncome(double x)
        {
            //Prompting user to enter their gross income before deductions
            income = x;
        }
        //Creating getIncome method
        public double getIncome()
        {
            return income;
        }


        //Creating setTax method
        public void setTax()
        {
            //Working out tax deduction
            tax = income * 0.15;
        }
        //Creating getTax method
        public double getTax()
        {
            return tax;
        }

        //Creating setGroceries method
        public void setGroceries(double x)
        {
            //prompting user to enther their monthly groceries expense
            groceries = x;
        }
        //Creating getGroceries Method
        public double getGroceries()
        {
            return groceries;
        }

        //Creating setWaterAndElectricity method
        public void setWaterAndElectricity(double x)
        {
            //prompting user to enther their monthly Water & Electricity expense
            waterAndElectricity = x;
        }
        //Creating getWaterAndElectricity method
        public double getWaterAndElectricity()
        {
            return waterAndElectricity;
        }

        //Creating setTravelCosts method
        public void setTravelCosts(double x)
        {
            //prompting user to enther their monthly travel costs
            travelCosts = x;
        }
        //Creating getTravelCosts method
        public double getTravelCosts()
        {
            return travelCosts;
        }

        //Creating setTeleCommunications method
        public void setTeleCommunications(double x)
        {
            //prompting user to enther their monthly Tele-Communications
            teleCommunications = x;
        }
        //Creating getTeleCommunications method
        public double getTeleCommunications()
        {
            return teleCommunications;
        }

        //Creating setOtherExpenses method
        public void setOtherExpenses(double x)
        {
            //prompting user to enther their other monthly expenses
            otherExpenses = x;
        }
        //Creating getOtherExpenses method
        public double getOtherExpenses()
        {
            return otherExpenses;
        }

        //Creating setExp method
        public void setExp()
        {
            //Storing all expense values in generic list
            List<double> expValue = new List<double>()
            {
                tax,
                groceries,
                waterAndElectricity,
                travelCosts,
                teleCommunications,
                otherExpenses,
            };
            //Storing all expense names in generic list
            List<string> expName = new List<string>()
            {
                "Tax",
                "Groceries",
                "Water And Electricity",
                "Travel Costs",
                "Tele-Communications",
                "Other Expenses",
            };

            //Sorting Expenses in descending order
            for (int i = 0; i < expValue.Count; i++)
            {
                for (int x = 0; x < expValue.Count; x++)
                {
                    if (expValue[i] > expValue[x])
                    {
                        double temp = expValue[i];
                        expValue[i] = expValue[x];
                        expValue[x] = temp;

                        string name = expName[i];
                        expName[i] = expName[x];
                        expName[x] = name;
                    }
                }
            }
        }
        //Creating getExp Method
        public List<double> getExp()
        {
            return Exp;
        }

        //Creating setTotalExpenses
        public void setTotalExpenses()
        {
            //Calculating total of all expenses
            totalExpenses = tax + groceries + waterAndElectricity + travelCosts + teleCommunications + otherExpenses;
            this.totalExpenses = totalExpenses;
        }

        //Creating getTotalExpenses
        public double getTotalExpenses()
        {
            return totalExpenses;
        }

        //Declaring homeRent Variable
        private double homeRent;

        //Creating setHomeRent method
        public void setHomeRent(double x)
        {
            //Prompting user to enter monthly rent
            homeRent = x;
        }
        //Creating getHomeRent method
        public double getHomeRent()
        {
            return homeRent;
        }

        //Declaring homePrice variable
        private double homePrice;
        //Declaring homeDeposit vriable
        private double homeDeposit;
        //Declaring homeInterest variable
        private double homeInterest;
        //Declaring homeMonths variable
        private double homeMonths;
        //Declaring homeLoan variable
        private double homeLoan;
        //Declaring homeMonthlyRepayment variable
        private double homeMonthlyRepayment;

        //Creating setHomePrice method
        public void setHomePrice(double x)
        {
            //Prompting user to enter the homePrice
            homePrice = x;
        }
        //Creating getHomePrice method
        public double getHomePrice()
        {
            return homePrice;
        }

        //Creating setHomeDeposit method
        public void setHomeDeposit(double x)
        {
            //Prompting user to enter the deposit amount
            homeDeposit = x;
        }
        //Creating getHomeDeposit method
        public double getHomeDeposit()
        {
            return homeDeposit;
        }


        //Creating setHomeInterest method
        public void setHomeInterest(double x)
        {
            //Prompting user to enter the interest rate
            homeInterest = x;
        }
        //Creating getHomeInterest method
        public double getHomeInterest()
        {
            return homeInterest;
        }

        //Creating setHomeMonths method
        public void setHomeMonths(double x)
        {
            //Prompting the user to enter the months
            homeMonths = x;

            //While statement to check if the number of months is between 240 and 360
            while ((homeMonths < 240) || (homeMonths > 360))
            {
                homeMonths = x;
            }
        }
        //Creating getHomeMonths method
        public double getHomeMonths()
        {
            return homeMonths;
        }

        //Creating setHomeLoan method
        public void setHomeLoan()
        {
            //Working out the home loan
            homeLoan = Math.Round((homePrice - homeDeposit) * (1 + ((homeInterest / 100) * (homeMonths / 12))), 2);
            this.homeLoan = homeLoan;
        }
        //Creating getHomeLoan method
        public double getHomeLoan()
        {
            return homeLoan;
        }

        //setHomeMonthlyRepayment method
        public void setHomeMonthlyRepayment()
        {
            //Working out the home loan monthly repayment
            homeMonthlyRepayment = Math.Round(homeLoan / homeMonths, 2);
            this.homeMonthlyRepayment = homeMonthlyRepayment;
        }
        //Creating getHomeMonthlyRepayment method
        public double getHomeMonthlyRepayment()
        {
            return homeMonthlyRepayment;
        }

        //Declaring vehicleRent variable
        protected double vehicleRent;
        //Declaring modelAndMake variable
        protected string modelAndMake;

        //Creating setVehicleRent method
        public void setVehicleRent(double x)
        {
            //Prompting user to enter the vehicle rent amount
            vehicleRent = x;
        }
        //Creating getVehicleRent method
        public double getVehicleRent()
        {
            return vehicleRent;
        }

        //Creating setModelAndmake method
        public void setModelAndMake(string x)
        {
            //Prompting user to enter the vehicle model & make
            modelAndMake = x;
        }
        //Creating getModelAndMake method
        public string getModelAndMake()
        {
            return modelAndMake;
        }

        //Declaring vehiclePrice variable
        protected double vehiclePrice;
        //Declaring vehicleDeposit variable
        protected double vehicleDeposit;
        //Declaring vehicleInterest variable
        protected double vehicleInterest;
        //Declaring vehicleInsurance variable
        protected double vehicleInsurance;
        //Declaring vehicleYears variable
        protected double vehicleYears = 5;
        //Declaring vehicleMonths variable
        protected double vehicleMonths = 60;
        //Declaring vehicleLoan variable
        protected double vehicleLoan;
        //Declaring vehicleMonthlyRepayment variable
        protected double vehicleMonthlyRepayment;

        //Creating setVehiclePrice method
        public void setVehiclePrice(double x)
        {
            //Prompting the user to enter the vehicle purchase price
            vehiclePrice = x;
        }
        //Creating getVehiclePrice method
        public double getVehiclePrice()
        {
            return vehiclePrice;
        }


        //Creating setVehicleDeposit method
        public void setVehicleDeposit(double x)
        {
            //Prompting the user to enter the deposit amount
            vehicleDeposit = x;
        }
        //Creating getVehicleDeposit method
        public double getVehicleDeposit()
        {
            return vehicleDeposit;
        }

        //Creating setVehicleInterest method
        public void setVehicleInterest(double x)
        {
            //Prompting the user to enter the interest rate
            vehicleInterest = x;
        }
        //Creating getVehicleInterest method
        public double getVehicleInterest()
        {
            return vehicleInterest;
        }


        //Creating setVehicleInsurance method
        public void setVehicleInsurance(double x)
        {
            //Prompting the user to enter the Insurance amount
            vehicleInsurance = x;
        }
        //Creating getVehicleInsurance method
        public double getVehicleInsurance()
        {
            return vehicleInsurance;
        }

        //Creating setVehicleLoan method
        public void setVehicleLoan()
        {
            //Calculating vehicle loan
            vehicleLoan = Math.Round((vehiclePrice - vehicleDeposit) * (1 + ((vehicleInterest / 100) * (vehicleYears))), 2);
            this.vehicleLoan = vehicleLoan;
        }
        //Creating getVehicleLoan method
        public double getVehicleLoan()
        {
            return vehicleLoan;
        }

        //Creating setVehicleMonthlyrepayment method
        public void setVehicleMonthlyRepayment()
        {
            //Calculating the vehicle monthly repayment
            vehicleMonthlyRepayment = Math.Round(vehicleLoan / vehicleMonths, 2);
            this.vehicleMonthlyRepayment = vehicleMonthlyRepayment;
        }
        //Creating getVehicleMonthlyRepayment method
        public double getVehicleMonthlyRepayment()
        {
            return vehicleMonthlyRepayment;
        }
        

    }
}
