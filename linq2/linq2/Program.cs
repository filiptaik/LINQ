using System;
using System.Linq;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 2, 6, 4, 5, 3, 2 };
            Console.WriteLine("Terve massiiv: " + string.Join(" ", m));
            Console.WriteLine("Elementide arv: " + m.Count());
            Console.WriteLine("Tagurpidi: " + string.Join(" ", m.Reverse()));
            Console.WriteLine("Neli esimest: " + string.Join(" ", m.Take(4)));
            Console.WriteLine("Kolm viimast: " + string.Join(" ", m.Reverse().Take(3).Reverse()));
            Console.WriteLine("Suurim: " + m.Max());
            Console.WriteLine("Vähim: " + m.Min());
            Console.WriteLine("Summa: " + m.Sum());
            Console.WriteLine("Keskmine: " + m.Average());
            Console.WriteLine("Sisaldab 3: " + m.Contains(3));
        }
    }
}
