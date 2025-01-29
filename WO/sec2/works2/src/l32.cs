// Lesson 38 Work here 

using Pastel;
using System.Drawing;

namespace works2.src
{
    public class Lesson32
    {
        public static void MainFunc()
        {
            Uti.PrintHeader("Lesson 32 - Strings");
        }

        public static void String1()
        {
            // String 1 
            int a = 10, b = 20, c = 30;
            string s = "The values are " + a + ", " + b + ", and " + c;
            Console.WriteLine(s.Pastel(Color.Green));

        }
    }
}