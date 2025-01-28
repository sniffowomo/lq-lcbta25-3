// Main Calculator function 

namespace src.Calc
{
    public class Calc
    {
        public static int Add(int a, int b)
        {
            Uti.ColorPrint("Addition");
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            Uti.ColorPrint("Subtraction");
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            Uti.ColorPrint("Multiplication");
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            Uti.ColorPrint("Division");
            return a / b;
        }
    }
}