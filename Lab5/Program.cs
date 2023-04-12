/*
Grading ID: K7989
Lab 5
Due 10/17/2021
CIS 199 - 01
This code asks for input from the user for temperatures. it will continue to ask for inputs until 999 is entered
It will count the number of inputs and calculate the average at the end.*/
using System;
using static System.Console;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            double avg;
            int total = 0;
            int count = 0;

            do
            {
                WriteLine("Enter Temperature");
                string input = ReadLine();
                if (int.TryParse(input, out temp) && temp >= -20 && temp <= 130)
                {
                    total += temp;
                    count++;
                }
                else if (temp != 999)
                {
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature");
                }
            } while (temp != 999);
            WriteLine($"Number of Valid temperatures: {count}");
            avg = total / count;
            WriteLine($"The mean temperature is {avg}");
          
        }
    }
}
