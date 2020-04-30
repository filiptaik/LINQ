using System;
using System.Collections.Generic;
using System.Linq;

namespace ylesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiiv = { 1, 7, 33, 11, 45, 765, 12, 9, 60 };
            Console.WriteLine("Kogu massiiv: " + string.Join(" ", massiiv));
            Console.WriteLine("Suurim: " + massiiv.Max());
            Console.WriteLine("Nelja esimese summa: " + string.Join(" ", massiiv.Take(4).Sum()));
            IEnumerable<int> esimesed = massiiv.Take(4);
            int[] massiiv2 = esimesed.ToArray<int>(); 
            Console.WriteLine("Neli esimest: " + string.Join(" ", massiiv2));
            Console.WriteLine("Neli esimest tagurpidi: " + string.Join(" ", massiiv2.Reverse()));


        }
    }
}
