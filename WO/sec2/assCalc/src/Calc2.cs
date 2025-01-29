// Calculator project from the tutorial 

using Pastel;
using System;
using System.Drawing;

namespace assCalc.src
{
    public class Calc2
    {
        // Header function 
        public static void Calc2Header()
        {
            Uti.PrintHeader("Calculator 2 - Assignment");
        }

        public static void Calc2App()
        {
            Console.WriteLine("Enter the first number: ".Pastel(Color.Plum));
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ".Pastel(Color.Aqua));
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($@"
Input1: {num1.ToString().Pastel(Color.Plum)}
Input2: {num2.ToString().Pastel(Color.Aqua)}
            ");

        }
    }
}
