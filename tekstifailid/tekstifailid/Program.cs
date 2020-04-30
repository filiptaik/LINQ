using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace tekstifailid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllLines("pikkused.txt").Select(p => int.Parse(p))
                .Max());
            int[] allnums = File.ReadLines("pikkused.txt").SelectMany(s => s.Select(int.Parse)).ToArray());
                //.OrderBy(p => p).Average().Count(p => p.Average());
        }
    }
}
