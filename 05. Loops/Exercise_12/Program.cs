using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPairs = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 0;
            int sum = 0;
            int lastSum = 0;
            int diff = 0;
            int maxDiff = 0;

            for (int i = 0; i < numOfPairs; i++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                sum = firstNumber + secondNumber;

                if(i==0)
                {
                    lastSum = sum;
                }

                if(lastSum!=sum)
                {
                    diff = Math.Abs(sum - lastSum);
                    //diff = Math.Max(sum, lastSum)-Math.Min(sum,lastSum);
                }
                if(diff>maxDiff)
                {
                    maxDiff = diff;
                }
                lastSum = sum;
            }
            if(diff ==0)
            {
                Console.WriteLine($"Yes, value = {sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff = {maxDiff}");
            }
        }
    }
}
