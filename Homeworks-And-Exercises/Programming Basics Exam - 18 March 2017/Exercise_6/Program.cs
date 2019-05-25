using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationNumber = 0;

            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    combinationNumber++;

                    if((i+j)==magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationNumber} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationNumber} combinations - neither equals {magicNumber}");
        }
    }
}
