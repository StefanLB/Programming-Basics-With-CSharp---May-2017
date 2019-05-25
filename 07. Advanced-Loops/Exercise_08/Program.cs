using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double factoriel = 1;

            for (int i = 2; i <= n; i++)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);

        }
    }
}
