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
            decimal record = decimal.Parse(Console.ReadLine());
            decimal meters = decimal.Parse(Console.ReadLine());
            decimal timeForOneMeter = decimal.Parse(Console.ReadLine());

            decimal delay = Math.Floor(meters / 15) * 12.5m;

            decimal ivanchoTime = meters * timeForOneMeter + delay;

            if(ivanchoTime<record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:f2} seconds.");
            }
            else if(ivanchoTime>=record)
            {
                Console.WriteLine($"No, he failed! He was {(ivanchoTime-record):f2} seconds slower.");
            }

        }
    }
}
