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

            // Calculator functions
            int add = Calc.Add(5, 5);
            int sub = Calc.Subtract(10, 5);
            int mul = Calc.Multiply(5, 5);
            int div = Calc.Divide(10, 5);

            Console.WriteLine(@$"
Addition: {add}.Pastel(Color.Green);
");


            Uti.ColorPrint("Thank you for using assCalc!!!!");

        }
    }
}
