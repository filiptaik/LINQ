using System;
using System.Linq;

namespace ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pikkused = { 178, 190, 167, 181, 180, 177, 183 };
            Console.WriteLine("Kõik pikkused: " +
                                string.Join(" ", pikkused));

            Console.WriteLine("180st suuremad: " +
                                string.Join(" ", pikkused.Where(a => a > 180)));

            Console.WriteLine("pikkuse järjekord: " +
                                string.Join(" ", pikkused.SelectMany(a => new int[] {a}).OrderBy(a => -a)));

            Console.WriteLine("Kuni väärtuseni 180: " +
                                string.Join(" ", pikkused.TakeWhile(a => a != 180)));

            Console.WriteLine("Alates väärtusest 180: " +
                                string.Join(" ", pikkused.SkipWhile(a => a != 180)));

            Console.WriteLine("pikkuse järjekord: " +
                                string.Join(" ", pikkused.SelectMany(a => new int[] { })));
        }
    }
}
