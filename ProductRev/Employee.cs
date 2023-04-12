//Grading ID here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll

{
    public class Employee

    {
        // #1 - Put needed backing fields here
        // Remember: Some properties may be
        // auto-implemented, so only create
        // backing fields for ones needed
        private int _currentPayPeriodHours;
        private double _yearlyIncome;
        private double _hourlyWage;
        public string EmployeeName { get; set; }
        

        public string Position { get; set; }
       
        
        public int CurrentPayPeriodHours
        {
            get
            {
                return _currentPayPeriodHours;
            }
            set
            {
                if(value > 0)
                {
                    _currentPayPeriodHours = value;
                }
                else
                {
                    _currentPayPeriodHours = 0;
                }
            }
            // #4 - Put your code here for get/set accessors
            // Set must validate!

        }

        public double YearlyIncome
        {
            get
            {
                return _yearlyIncome;
            }
            set
            {
                if( value > 0)
                {
                    _yearlyIncome = value;
                }
                else
                {
                    _yearlyIncome = 0;
                }
            }
            // #5 - Put your code here for get/set accessors
            // Set must validate!

        }

        public double HourlyWage
        {
            get
            {
                return _hourlyWage;
            }
            set
            {
                if (value > 0)
                {
                    _hourlyWage = value;
                }
                else
                {
                    _hourlyWage = 0;
                }
            }
            // #5 - Put your code here for get/set accessors
            // Set must validate!

        }

        public Employee(string name, string position, int hours, double hourlyWage, double yearlyIncome)
        {
            EmployeeName = name;
            Position = position;
            CurrentPayPeriodHours = hours;
            HourlyWage = hourlyWage;
            YearlyIncome = yearlyIncome;
            // #6 - Put your code here for constructor
            // Be sure your parameters get validated through properties

        }

        public double CalcCurrentPeriodWage()
        {
            // #7 - Put your code here to calculate value of
            // this item in inventory
            // Example: 2500 @ $4.99 = $12,475
            return _currentPayPeriodHours * _hourlyWage;
        }

        public override string ToString()
        {
            double[] TaxRates = { .10, .12, .22, .24, .32, 35, .37 };
            double[] TaxBracketMins = { 0, 9951, 40526, 86376, 164926, 209426, 523601 };

            bool taxRateFound = false;
            double taxRate = 0; //default to 0

            for (int i = TaxBracketMins.Length - 1; i >= 0 && !taxRateFound; --i)
            {
                if (TaxBracketMins[i] <= this.YearlyIncome)
                {
                    taxRateFound = true;
                    taxRate = TaxRates[i];
                }
            }

            // #8 - Put your code here to create formatted string
            // Use format that would produce a string like:
            // "Wage: $1,000.00 for Employee: John Smith:Manager (40 @ $25.00) Tax Rate (Based on Yearly Income): 0.24"
            // where John Smith is the name, Manager is the
            // position, 40 is the hours, and 25 is the hourly wage, with 1000 being the total pay for the period.
            // Finally, .24 is the taxRate, by referencing the taxRate variable above calculated  in the for loop from the yearlyIncome
            // no new lines are needed
            return $"Wage: {CalcCurrentPeriodWage()} for Employee: {EmployeeName}:{Position} ({CurrentPayPeriodHours} @ {HourlyWage}) Tax Rate (Based on Yearly Income):{taxRate}";
        }
    }
}
