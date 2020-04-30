using System;
using System.IO;
using System.Linq;

namespace n2itrakendus
{
    class Program
    {
        static void Main(string[] args)
        {
            var joogid = File.ReadAllLines("inventuur.txt")
                             .Select(s => s.Split(' '))
                             .Select(m => new { nimetus = m[0], puudu = (((decimal.Parse(m[1])*0.01m) - (decimal.Parse(m[2])*0.01m))/10)*10
                              ,hind = int.Parse(m[3])
                              , maksumus = Math.Floor(((decimal.Parse(m[1]) * 0.01m) - (decimal.Parse(m[2]) * 0.01m)) * decimal.Parse(m[3]) * 100)/100});
            var kõrgeimhind = joogid.OrderBy(jook => -jook.maksumus);

            foreach (var jook in kõrgeimhind)
            {
                Console.WriteLine(jook.nimetus + " -  puudu(dl):  " + jook.puudu +
                                  ", hind dl kaupa: " + jook.hind + 
                                  ", maksumus: " + jook.maksumus + "€");
            }
            File.WriteAllLines("puudujääk.txt",
                kõrgeimhind.Select(jook => jook.nimetus + " -  puudu:  " + jook.puudu + "dl" +
                                  ", hind detsiliitri kohta: " + jook.hind + "€" +
                                  ", maksumus: " + jook.maksumus + "€"));
        }
    }
}
