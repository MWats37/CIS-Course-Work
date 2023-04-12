/*
Grading ID: K7989
Lab 4
Due: 10/03/2021
CIS 199 - 01
This code takes input from the user to determine if their application will be accepted or rejected based
on if they score high enough. It also keeps a running total of accepted and rejected applications.
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

namespace Lab4
{
    public partial class Lab4Form : Form
    {
        //Accepted and rejected variables being declared for running total
        int accept = 0;
        int reject = 0;
        public Lab4Form()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Adding 1 for a running total of accepted and denied applications
            
            

            //decalring variables of GPA and test scores
            double gradePointAverage;
            uint testScore;

            //using if/else statements and TryParsing the user input for GPA and displaying if the input is valid or not valid
            if (double.TryParse(gradePointAverageTextBox.Text, out gradePointAverage) && gradePointAverage > 0 && gradePointAverage <= 4.0)
            {

                MessageBox.Show("User input is valid");
            }
            else
            {
                MessageBox.Show("User input is not valid");
            }

            //using if/else statements and TryParsing the user input for test scores and displaying if the input is valid or not valid
            if (uint.TryParse(admissionsTestScoreTextBox.Text, out testScore) && testScore > 0 && testScore <= 100)
            {
                MessageBox.Show("User input is valid");
            }
            else
            {
                MessageBox.Show("User input is not valid");
            }

            //Testing the input values to see if the application will be accepted or rejected. Showing the running total for accepted and rejected applications too
            if (gradePointAverage >= 3.0 && testScore >= 60 || gradePointAverage < 3.0 && testScore >= 80)
            {
                MessageBox.Show("Accepted");
                accept++;
                acceptedApplicationsOutLabel.Text = ($"{accept}");
            }
            else
            {
                MessageBox.Show("Rejected");
                reject++;
                rejectedApplicationOutLabel.Text = ($"{reject}");
            }
        }
    }
}
