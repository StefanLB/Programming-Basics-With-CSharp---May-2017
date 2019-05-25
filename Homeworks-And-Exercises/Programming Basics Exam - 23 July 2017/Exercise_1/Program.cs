using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal wardrobeSide = decimal.Parse(Console.ReadLine());

            decimal areaCm = (length*100) * (width*100);
            decimal usableArea = areaCm - (wardrobeSide *100)* (wardrobeSide*100) - 0.1m *areaCm;

            decimal numberOfDancers = Math.Floor(usableArea / 7040);

            Console.WriteLine(numberOfDancers);

        }
    }
}
