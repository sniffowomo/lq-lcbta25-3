// Utility functions here 

using Pastel;
using System;
using System.Drawing;

namespace works2.src
{
    public class Uti
    {

        public static void PrintHeader(string header)
        {
            Console.WriteLine($@"
{"───── ⋆⋅☆⋅⋆ ─────".Pastel(Color.DarkRed)}
{header.Pastel(Color.Cyan)}
{"───── ⋆⋅☆⋅⋆ ─────".Pastel(Color.DarkRed)}
            ");

        }
    }
}