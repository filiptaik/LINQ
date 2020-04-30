using System;
using System.Linq;

namespace hulgatehted1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jukukeeled = { "eesti", "vene" };
            string[] katikeeled = { "eesti", "soome", "inglise" };
            Console.WriteLine("Juku: " + string.Join(" ", jukukeeled) + " | Kati: " + string.Join(" ", katikeeled));
            Console.WriteLine("Kahe peale oskavad: " +
                                string.Join(" ", jukukeeled.Union(katikeeled)));
            Console.WriteLine("Mõlemad oskavad (ühisosa): " +
                                string.Join(" ", jukukeeled.Intersect(katikeeled)));
            Console.WriteLine("Ainult Juku oskab: " +
                                string.Join(" ", jukukeeled.Except(katikeeled)));
            Console.WriteLine("Kõik oskused loetelus: " +
                                string.Join(" ", jukukeeled.Concat(katikeeled)));

        }
    }
}
