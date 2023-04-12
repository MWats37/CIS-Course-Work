/* Grading ID:K7989, Lab 2, Due: 09/19/2021, CIS 199 - 01. 
 * This code is meant to calculate a tip based off of a meal price.
 * The code takes the input from the text box and multiplies it by 15%, 18%, and 20% to show what each tip amount would be. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTipButton_Click(object sender, EventArgs e)
        {
            double priceInput = double.Parse(mealPriceTextBox.Text);

            double tipOut15 = priceInput * 0.15;
            tipOutputLable1.Text = String.Format("{0}", tipOut15.ToString("C"));

            double tipOut18 = priceInput * 0.18;
            tipOutputLable2.Text = String.Format("{0}", tipOut18.ToString("C"));

            double tipOut20 = priceInput * 0.20;
            tipOutputLable3.Text = String.Format("{0}", tipOut20.ToString("C"));
        }
    }
}
