// Grading ID Here : K7989

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentValue;   // Current employees wage 
            double totalValue = 0; // Running total of employees's wages
            Employee[] Employees; // Employees

            // #1 - Put code here to construct 3 Employees
            Employee employee1 = new Employee("John White", "Manager", 40, 15.00, 21000.01);
            Employee employee2 = new Employee("Eric Ericson", "First Assistant", 35, 13.00, 18000.45);
            Employee employee3 = new Employee("Alfred Boduckle", "New Recruit", 30, 12.00, 16000.89);

            Employees = new Employee[] { employee1, employee2, employee3 };

            WriteLine($"Employee Payroll Report:");

            // #2 - Complete loop to step through array of employees
            for (int index = 0; index < Employees.Length; ++index)
            {

                currentValue = Employees[index].CalcCurrentPeriodWage(); // #3 - Complete statement to calculate value of current employee
                                  //      from array by calling CalcCurrentPeriodWage

                totalValue += currentValue; // #4 - Add currentValue into running total

                // #5 - Output currentValue, with currency formatting, followed by string representation
                //      of current employee from array
                WriteLine($"Current Value: {currentValue:C} of {Employees[index].EmployeeName}");
            }

            WriteLine("\nTotal Wages for All Employees This Period:");
            // #6 - Output totalValue of Gross Pay, with currency formatting
            WriteLine($"Total Value of Gross Pay {totalValue:C}");
        }
    }
}
