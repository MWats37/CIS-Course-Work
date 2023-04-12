/* Grading ID: K7989
Lab 3
Due: 09/26/2021
CIS 199 - 01
This code takes input from the radius text box and converts it to a double.
The radius input is then put through the forumals for diamter, surface area and volume and the results are displayed*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void calulcateButton_Click(object sender, EventArgs e)
        {
            // converting the input into a double and declaring radiusInput variable
            double radiusInput = double.Parse(radiusOsSphereTextBox.Text);

            // declaring the diameter, are and volume variables
            double diameter;
            double area;
            double volume;

            // calculating dimensions of sphere
            diameter = 2 * radiusInput;
            area = (4 * Math.PI) * Math.Pow(radiusInput, 2);
            volume = ((4 * Math.PI) * Math.Pow(radiusInput, 3) / 3);

            //display the dimensions of sphere
            diameterOutLabel.Text = String.Format("{0}", diameter.ToString("N"));
            surfaceAreaOutLabel.Text = String.Format("{0}", area.ToString("N"));
            volumeOutLabel.Text = String.Format("{0}", volume.ToString("N"));
            
        }
    }
}
