using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal skumriqPrice = decimal.Parse(Console.ReadLine());
            decimal cacaPrice = decimal.Parse(Console.ReadLine());
            decimal kgPalamud = decimal.Parse(Console.ReadLine());
            decimal kgSafrid = decimal.Parse(Console.ReadLine());
            decimal kgMidi = decimal.Parse(Console.ReadLine());

            decimal totalToPay = skumriqPrice * 1.6m * kgPalamud + cacaPrice * 1.8m * kgSafrid + 7.5m * kgMidi;

            Console.WriteLine($"{totalToPay:f2}");

        }
    }
}
