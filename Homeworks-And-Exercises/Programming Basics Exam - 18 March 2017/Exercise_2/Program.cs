using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            if(neededHours<=(numberOfWorkers*workingDays*8))
            {
                Console.WriteLine($"{numberOfWorkers*workingDays*8-neededHours} hours left");
            }
            else if(neededHours > (numberOfWorkers * workingDays * 8))
            {
                Console.WriteLine($"{neededHours-numberOfWorkers*workingDays*8} overtime");
                Console.WriteLine($"Penalties: {(neededHours - numberOfWorkers * workingDays * 8)*workingDays}");
            }

        }
    }
}
