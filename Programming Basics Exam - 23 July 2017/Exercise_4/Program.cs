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
            int trainingDays = int.Parse(Console.ReadLine());
            int numDancers = int.Parse(Console.ReadLine());
            decimal wastedEnergy = 0m;

            for (int i = 1; i <= trainingDays; i++)
            {
                int currentDayHours = int.Parse(Console.ReadLine());

                if (i%2==0)
                {
                    if (currentDayHours%2==0)
                    {
                        wastedEnergy += 68 * numDancers;
                    }
                    else
                    {
                        wastedEnergy += 65 * numDancers;
                    }
                }
                else
                {
                    if (currentDayHours%2==0)
                    {
                        wastedEnergy += 49 * numDancers;
                    }
                    else
                    {
                        wastedEnergy += 30 * numDancers;
                    }
                }
            }

            decimal averageWasted = wastedEnergy / numDancers / trainingDays;

            if(averageWasted<=50)
            {
                Console.WriteLine($"They feel good! Energy left: {(100-averageWasted):f2}");
            }
            else
            {
                Console.WriteLine($"They are wasted! Energy left: {(100-averageWasted):f2}");
            }
        }
    }
}
