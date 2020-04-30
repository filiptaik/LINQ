using System;
using System.Collections.Generic;
using System.Linq;

namespace linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 2, 6, 4, 5, 3, 2 };
            Console.WriteLine(string.Join(" ", m));

            Console.WriteLine();

            IEnumerable<int> erinevad = m.Distinct();
            int[] m2 = erinevad.ToArray<int>();
            Console.WriteLine(string.Join(" ", erinevad));

            Console.WriteLine();

            /*
            foreach(int element in m2)
            {
                Console.WriteLine(element);
            }
            */
            Console.WriteLine(string.Join(" ", m2));
            
            Console.WriteLine();

            int[] m3 = m.Distinct().ToArray();
            Console.WriteLine(string.Join(" ", m3));

        }
    }
}
