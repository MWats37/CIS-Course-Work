using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            // Declaring constants for fixed rates
            const double PEOPLE_RATE_A = 2;
            const double DISTANCE_RATE_A = 0.02;
            const double DISTANCE_RATE_B = 0.10;
            const double PEOPLE_RATE_C = 0.25;


            //Declaring passenger variable and passenger cost variable

            double peopleCostA = 0;
            double peopleCostB = 0;
            double peopleCostC = 0;

            //Declaring distance cost variables for each company
            double distanceCostA = 0;
            double distanceCostB = 0;
            double distanceCostC = 0;

            //Declaring car type cost variables for each company
            double carTypeCostA = 0;
            double carTypeCostB = 0;
            double carTypeCostC = 0;

            //Declaring the variable for total cost for each company
            double totalCostA;
            double totalCostB;
            double totalCostC;

            //if statement to collect information on number of passengers and calculate costs for each company
            if (int.TryParse(passengerTextBox.Text, out int people) && people <= 12 && people >= 0)
            {
                peopleCostA = people * PEOPLE_RATE_A;
                peopleCostC = people * PEOPLE_RATE_C;

                if (people <=2 && people >= 0)
                {
                    peopleCostB = people * 20;
                }

                else if (people <= 6 && people >= 3)
                {
                    peopleCostB = people * 15;
                }

                else if (people <= 12 && people >= 7)
                {
                    peopleCostB = people * 5;
                }
                 
            }
            else
            {
                MessageBox.Show("Not a valid number of people. Please enter a number of people 1 to 12.");
            }

            //if statement for distance calculations for each company
            if (double.TryParse(distanceTextBox.Text, out double distance) && distance >= 0)
            {
                distanceCostA = distance * DISTANCE_RATE_A;
                distanceCostB = distance * DISTANCE_RATE_B;
            }

            if (distance <= 200)
            {
                distanceCostC = 40;

                if (distance <= 199 && distance >= 100)
                {
                    distanceCostC = 35;

                }

                else if (distance <= 99 && distance >= 50)
                {
                    distanceCostC = 25;
                }

                else if (distance <= 49 && distance >= 10)
                {
                    distanceCostC = 15;
                }

                else if (distance <= 9 && distance >= 0)
                {
                    distanceCostC = 5;
                }
            }

            
            else
            {
                MessageBox.Show("Invalid Distance. Please enter a valid distance.");
            }

            //if statements to take values in combobox and assign values to car types for each companies
            
                if (carTypeComboBox.SelectedIndex == 0)
                {
                    carTypeCostA = 50;
                    carTypeCostB = 40;
                    carTypeCostC = 20;
                }
                else if (carTypeComboBox.SelectedIndex == 1)
                {
                    carTypeCostA = 40;
                    carTypeCostB = 40;
                    carTypeCostC = 20;
                }
                else if (carTypeComboBox.SelectedIndex == 2)
                {
                    carTypeCostA = 25;
                    carTypeCostB = 25;
                    carTypeCostC = 20;
                }
                else if (carTypeComboBox.SelectedIndex == 3)
                {
                    carTypeCostA = 15;
                    carTypeCostB = 15;
                    carTypeCostC = 20;
                }
                else if (carTypeComboBox.SelectedIndex == 4)
                {
                    carTypeCostA = 7;
                    carTypeCostB = 15;
                    carTypeCostC = 20;
                }
            
            //Calculating the total cost for each company and comparing prices for best deal

            totalCostA = peopleCostA + distanceCostA + carTypeCostA;
            totalCostB = peopleCostB + distanceCostB + carTypeCostB;
            totalCostC = peopleCostC + distanceCostC + carTypeCostC;


            companyACostOutLabel.Text = ($"{totalCostA:C}");
            companyBCostOutLabel.Text = ($"{totalCostB:C}");
            companyCCostOutLabel.Text = ($"{totalCostC:C}");

            //Showing which company has the lowest cost
            if (totalCostA < totalCostB && totalCostA < totalCostC)
            {
                lowestCostLabel.Text = ("The lowest cost company is: A");
            }

            else if (totalCostB < totalCostA && totalCostB < totalCostC)
            {
                lowestCostLabel.Text = ("The lowest cost company is: B");
            }

            else if (totalCostC < totalCostA && totalCostC < totalCostB)
            {
                lowestCostLabel.Text = ("The lowest cost company is: C");
            }

            else if (totalCostA == totalCostB && totalCostA < totalCostC && totalCostB < totalCostC)
            {
                lowestCostLabel.Text = ("There is a tie between company A and B");
            }

            else if (totalCostA == totalCostC && totalCostA < totalCostB && totalCostC < totalCostB)
            {
                lowestCostLabel.Text = ("There is a tie between company A and C");
            }

            else if (totalCostB == totalCostC && totalCostB < totalCostA && totalCostC < totalCostA)
            {
                lowestCostLabel.Text = ("There is a tie between company B and C");
            }







        }
    }
}
