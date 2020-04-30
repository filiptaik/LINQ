using System;
using System.Linq;

namespace avaldised
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 2, 6, 4, 5, 3, 2 };
            Console.WriteLine("Kogu massiiv: " +
                                string.Join(" ", m));
            Console.WriteLine("Kui palju on neljast suuremaid arve: " +
                                m.Count(a => a > 4));

            Console.WriteLine("Neljast suuremad arvud: " +
                               string.Join(" ", m.Where(a => a > 4)));

            Console.WriteLine("Esimene neist: " + 
                               m.First(a => a > 4));

            Console.WriteLine("Kahega korrutatult: " +
                               string.Join(" ", m.Select(a => a.ToString())));

            Console.WriteLine("Arvud ja ruudud: " +
                               string.Join(" ", m.SelectMany(a => new int[] { a, a * a })));

            Console.WriteLine("Kuni väärtuseni 5: " +
                               string.Join(" ", m.TakeWhile(a => a != 5)));

            Console.WriteLine("Alates väärtusest 5: " +
                               string.Join(" ", m.SkipWhile(a => a != 5)));


        }
    }
}
