using System;
using System.Collections.Generic;
using System.Linq;

namespace ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peatus0 = {"23", "67", "68", "11", "9"};
            int[] peatus1 = { 23, 67, 68, 11, 9 };
            int[] peatus2 = {23, 9, 56, 43, 21};
            int[] peatus3 = {8, 23, 69, 5};

            Console.WriteLine("Kõigis peatub : " +
                 string.Join(" ", peatus1.Intersect(peatus2).Intersect(peatus3)));
            Console.WriteLine("Ei saa teise peatusesse: " +
                 string.Join(" ", peatus1.Except(peatus2)));
            Console.WriteLine("Kõik peatused: " +
                 string.Join(" ", peatus1.Concat(peatus2).Concat(peatus3)));
        }
    }
}
