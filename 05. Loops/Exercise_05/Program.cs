using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            int largestNumber = int.MinValue;

            for (int i = 0; i < numOfNums ; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if(largestNumber<input)
                {
                    largestNumber = input;
                }
            }
            Console.WriteLine(largestNumber);

        }
    }
}
