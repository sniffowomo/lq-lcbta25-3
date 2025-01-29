// Lesson 39 - Swtich Statements 

namespace works2.src
{
    public class Lesson39
    {
        public static void MainFunc()
        {
            Uti.PrintHeader("Lesson 39 - Switch Statements");
        }

        public static void Switch1()
        {
            Uti.PrintHeader2("Switch 1");
            // Switch 1 
            int a = 10, b = 20, c = 30;

            string s = "The values are " + a + ", " + b + ", and " + c;

            Console.WriteLine($"Strings in sequence - {a}, {b}, {c}".Pastel(Color.Yellow));

        }
    }
}