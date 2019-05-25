using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDancers = int.Parse(Console.ReadLine());
            decimal points = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = Console.ReadLine();
            decimal prize = 0m;

            if (location== "Bulgaria")
            {
                prize = points * numDancers;

                if (season == "summer")
                {
                    prize *= 0.95m;
                }
                else if(season =="winter")
                {
                    prize *= 0.92m;
                }

            }
            else if(location== "Abroad")
            {
                prize = points * numDancers*1.5m;

                if (season == "summer")
                {
                    prize *= 0.9m;
                }
                else if (season == "winter")
                {
                    prize *= 0.85m;
                }
            }

            Console.WriteLine($"Charity - {(0.75m*prize):f2}");
            Console.WriteLine($"Money per dancer - {(0.25m*prize/numDancers):f2}");

        }
    }
}
