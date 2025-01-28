// Main entry point 

using assCalc.src;

namespace assCalc
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Uti.ColorPrint("Welcome to assCalc!!!!");

            // Addition
            int add = Calc.Add(5, 5);
            Uti.ColorPrint($"Result: {add}");

            // Subtraction
            int sub = Calc.Subtract(10, 5);
            Uti.ColorPrint($"Result: {sub}");

            // Multiplication
            int mul = Calc.Multiply(5, 5);
            Uti.ColorPrint($"Result: {mul}");

            // Division
            int div = Calc.Divide(10, 5);
            Uti.ColorPrint($"Result: {div}");

            Uti.ColorPrint("Thank you for using assCalc!!!!");

        }
    }
}
