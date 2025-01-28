// Main entry point 

using assCalc.src;
using Pastel;
using System.Drawing;

namespace assCalc
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Uti.ColorPrint("Welcome to assCalc!!!!");

            // Calculator functions
            int add = Calc.Add(5, 5);
            int sub = Calc.Subtract(10, 5);
            int mul = Calc.Multiply(5, 5);
            int div = Calc.Divide(10, 5);

            Console.WriteLine($@"
Addition: {add.ToString().ColorPrint(ConsoleColor.Green)}
Subtraction: {sub.ToString().ColorPrint(ConsoleColor.Cyan)}
Multiplication: {mul.ToString().ColorPrint(ConsoleColor.Yellow)}
Division: {div.ToString().ColorPrint(ConsoleColor.Magenta)}
".Trim());



            Uti.ColorPrint("Thank you for using assCalc!!!!");

        }
    }
}
