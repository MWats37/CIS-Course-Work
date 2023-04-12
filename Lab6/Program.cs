/*
Grading ID:K7989
Lab 6
Due: 10/31/2021
CIS 199 - 01
This code uses loops and nested loops in order to print out different star patterns
 */
using System;
using static System.Console;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring max rows constant
            const int MAX_ROWS = 10;
            const int MIN_ROWS = 1;

            //for loop and nested for loop for creating Pattern A of stars
            WriteLine("Pattern A");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int star = 1; star <= row; star++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            //for loop and nested for loop for creating Pattern B of stars
            WriteLine("Pattern B");
            WriteLine();
            for (int row = 10; row >= MIN_ROWS; row--)
            {
                for (int star = 1; star <= row; star++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();

            //for loop and nested loops for creating pattern C of stars
            WriteLine("Pattern C");
            WriteLine();
            for (int row = MAX_ROWS; row >= MIN_ROWS; row--)
            {
                for (int space = MAX_ROWS - row; space > 0; space --)
                {
                    Write(" ");
                }

                for (int star = row; star > 0; star--)
                {
                    Write("*");
                }
                WriteLine();
            }

            //for loop and nested loops for creating pattern D of stars
            WriteLine("Pattern D");
            WriteLine();
            for (int row = 1; row <= MAX_ROWS; row++)
            {
                for (int space = MAX_ROWS - row; space > 0; space--)
                {
                    Write(" ");
                }

                for (int star = 1; star <= row; star++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
