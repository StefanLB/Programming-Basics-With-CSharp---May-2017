using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int partsOfProject = int.Parse(Console.ReadLine());
            decimal prizePerPoint = decimal.Parse(Console.ReadLine());
            int totalPoints = 0;

            for (int i = 1; i <= partsOfProject; i++)
            {
                int currentPartPoints = int.Parse(Console.ReadLine());
                if(i%2==0)
                {
                    currentPartPoints *= 2;
                }
                totalPoints += currentPartPoints;
            }

            decimal totalPrize = prizePerPoint * totalPoints;

            Console.WriteLine($"The project prize was {totalPrize:f2} lv.");

        }
    }
}
