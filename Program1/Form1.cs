/*Grading ID: K7989
Program 1
Due: 09/30/2021
CIS 199 - 01
This code takes input for dimensions of a pool in feet and converts it to cubic yard.
It then calculates estimated costs for pool construction.
This includes whether the pool is above ground or below ground and if there will be a diving board.*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class ProgramOne : Form
    {
        public ProgramOne()
        {
            InitializeComponent();
        }

        private void calculateEstimateButton_Click(object sender, EventArgs e)
        {
            //Creating a named constant for yard conversion and labor
            const double YARDS_CONVERSION = 27;
            const double LABOR_COST_RATE = 3.25;
            const double WASTE_PERCENTAGE = 1.1;
            const double DIVING_BOARD_LABOR = 50;
            const double BELOW_GROUND_CHARGE = 15;

            //Declaring double variables for each respective input and parsing the TextBoxes
            double maxWidth = double.Parse(maxWidthTextBox.Text); 
            double maxLength = double.Parse(maxLengthTextBox.Text); 
            double maxDepth = double.Parse(maxDepthTextBox.Text);
            double priceOfMaterials = double.Parse(materialsPriceTextBox.Text);

            //Declaring int variables for each respective input and parsing the TextBoxes
            int excavation = int.Parse(excavationNeededTextBox.Text);
            int divingBoard = int.Parse(divingBoardTextBox.Text);

            //Creating the output for the cubic yards label
            double cubicYards = (maxWidth * maxLength * maxDepth) / YARDS_CONVERSION;
            cubicYardsOutLabel.Text = String.Format("{0}", cubicYards.ToString("N1"));

            //Creating the output for the cost of materials label
            double costOfMaterials = cubicYards * priceOfMaterials * WASTE_PERCENTAGE;
            materialsCostOutLable.Text = String.Format("{0}", costOfMaterials.ToString("C"));

            //Creating the output for the excavation label
            double excavationCost = excavation * (BELOW_GROUND_CHARGE * cubicYards);
            excavationCostOutLable.Text = String.Format("{0}", excavationCost.ToString("C"));

            //Creating the output for the labor cost label
            double laborCost = (cubicYards * LABOR_COST_RATE) + (divingBoard * DIVING_BOARD_LABOR);
            laborCostOutLabel.Text = String.Format("{0}", laborCost.ToString("C"));

            //Creating the output for the total cost label
            double totalCost = excavationCost + costOfMaterials + laborCost;
            totalCostOutLabel.Text = String.Format("{0}", totalCost.ToString("C"));
        }
    }
}
