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
            int days = int.Parse(Console.ReadLine());
            int numOfBakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            decimal totalMoneyRaised = days * numOfBakers *0.875m*(cakes*45m+gofreti*5.8m+pancakes*3.2m);

            Console.WriteLine($"{totalMoneyRaised:f2}");
        }
    }
}
