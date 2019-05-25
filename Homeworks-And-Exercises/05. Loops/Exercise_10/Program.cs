using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNumbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int largestNumber = int.MinValue;

            for (int i = 0; i < numOfNumbers; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum = sum + input;
                if(largestNumber<input)
                {
                    largestNumber = input;
                }

            }
            if(largestNumber==(sum-largestNumber))
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {largestNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs((sum-largestNumber)-largestNumber)}");
            }


        }
    }
}
