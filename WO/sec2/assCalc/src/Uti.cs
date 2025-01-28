// Utility functions here 

using Pastel;
using System;
using System.Drawing;

namespace assCalc.src
{
    public class Uti
    {
        public static void ColorPrint(string message)
        {
            Console.WriteLine($"{message}".Pastel(Color.FromArgb(255, 255, 0)));
        }

        public static void PrintHeader(string header)
        {
            Console.WriteLine($@"
{"_____________________________".Pastel(Color.DarkRed)}
{header.Pastel(Color.Cyan)}
{"______________________________".Pastel(Color.DarkRed)}
            ");

        }
    }
}