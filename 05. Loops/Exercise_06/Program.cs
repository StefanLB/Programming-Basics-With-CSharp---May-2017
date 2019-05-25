using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNums = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0; i < numOfNums; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (minNumber > input)
                {
                    minNumber = input;
                }
            }
            Console.WriteLine(minNumber);

        }
    }
}
