/*
 Grading ID = K7989
Program 3
Due: 11/11/2021
CIS 199 - 01
This Code takes input from a combobox and textboxes in order to calculate the cost of meals based on servings
and what city they are in. SHipment fees and service fees are also added on to the final price.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    public partial class uThankItWeMakeItForm : Form
    {
        public uThankItWeMakeItForm()
        {
            InitializeComponent();
        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            //declaring constants for shipment fees for each city
            const double LOUISVILLE_FEE = 0.06;
            const double LEXINGTON_FEE = 0.0717;
            const double INDIANAPOLIS_FEE = 0.07;
            const double NASHVILLE_FEE = 0.0874;

            double shipmentFee = 0;

            //if statements to access the combobox selection
            if ( cityComboBox.SelectedIndex == 0)
            {
                shipmentFee = LOUISVILLE_FEE;
            }
            else if (cityComboBox.SelectedIndex == 1)
            {
                shipmentFee = LEXINGTON_FEE;
            }
            else if (cityComboBox.SelectedIndex == 2)
            {
                shipmentFee = INDIANAPOLIS_FEE;
            }
            else if (cityComboBox.SelectedIndex == 3)
            {
                shipmentFee = NASHVILLE_FEE;
            }

            
            //parallel arrays for the entree number and cost per serving
            int[] entrees = { 10001, 10002, 10003, 10004, 10005, 10006, 10007 };
            double[] servingCosts = { 7.87, 9.51, 10.73, 9.99, 11.99, 5.00, 4.58 };

            //declaring cost variables
            double initialCost = 0;
            double adjustedCost;
            double shipmentCost;
            double totalPrice = 0;
            double serviceFee = 0;
            int servings;

            //TryParse for entree number and quantity textboxes
            int.TryParse(entreeTextBox.Text, out int entreeNumber);
            int.TryParse(quantityTextBox.Text, out servings);

            //loop for the entrees and servingCost arrays to calculate initial cost of meal
            for (int i = 0; i < entrees.Length; i++)
            {
                if (entreeNumber == entrees[i])
                {
                    initialCost = servings * servingCosts[i];
                }

            }

            //if statementTo show that any input not = to an entree number would be invalid
            if (entreeNumber != entrees[0] && entreeNumber != entrees[1] && entreeNumber != entrees[2] && entreeNumber != entrees[3] && entreeNumber != entrees[4] && entreeNumber != entrees[5] && entreeNumber != entrees[6])
            {
                MessageBox.Show("Invalid entree number");
            }
            
            //if statement for service fees and servings
            if (servings >= 0 && servings <=5)
            {
                serviceFee = 0.15;
            }
            else if (servings >= 6 && servings <= 10)
            {
                serviceFee = 0.10;
            }
            else if (servings >= 11 && servings <= 20)
            {
                serviceFee = 0.05;
            }
            else if (servings >= 21)
            {
                serviceFee = 0.0;
            }

            //calculating the adjusted cost
            adjustedCost = (initialCost * serviceFee) + initialCost;

            //calculating shipment cost
            shipmentCost = adjustedCost * shipmentFee;

            //calculating total price
            totalPrice = adjustedCost + shipmentCost;

            //output for the different cost labels
            initialCostOutLabel.Text = ($"{initialCost:C}");
            adjustedCostOutLabel.Text = ($"{adjustedCost:C}");
            shipmentCostOutLabel.Text = ($"{shipmentCost:C}");
            totalPriceOutLabel.Text = ($"{totalPrice:C}");
        }
    }
}
