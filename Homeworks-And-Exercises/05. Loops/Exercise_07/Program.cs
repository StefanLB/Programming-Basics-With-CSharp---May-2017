using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= 2*numOfNums; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (i<=numOfNums)
                {
                    leftSum = leftSum + input;
                }
                else
                {
                    rightSum = rightSum + input;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
            }

        }
    }
}
