using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal daysHungry = decimal.Parse(Console.ReadLine());
            decimal foodLeftNotToDie = decimal.Parse(Console.ReadLine());
            decimal kgDogEatsPerDay = decimal.Parse(Console.ReadLine());
            decimal kgCatEatsPerDay = decimal.Parse(Console.ReadLine());
            decimal gTortoiseEatsPerDay = decimal.Parse(Console.ReadLine());

            decimal liveOrDie = foodLeftNotToDie - daysHungry * (kgDogEatsPerDay + kgCatEatsPerDay + gTortoiseEatsPerDay / 1000);

            if(liveOrDie>=0)
            {
                Console.WriteLine($"{Math.Floor(liveOrDie)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(Math.Floor(liveOrDie))} more kilos of food are needed.");
            }
        }
    }
}
