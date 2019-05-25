using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numOfNums; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if(i%2==0)
                {
                    evenSum = evenSum + input;
                }
                else
                {
                    oddSum = oddSum + input;
                }
            }

            if(evenSum==oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)}");
            }

        }
    }
}
