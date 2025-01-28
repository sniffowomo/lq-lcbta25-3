// Utility functions here 

using Pastel;
using System;
using System.Drawing;

namespace src.Uti
{
    public class Uti
    {
        public static void ColorPrint(string message)
        {
            Console.WriteLine("Welcome to assCalc!".Pastel(Color.FromArgb(255, 255, 0)));
        }
    }
}