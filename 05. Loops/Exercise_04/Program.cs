using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNumbs = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numOfNumbs; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.WriteLine(sum);
        }
    }
}
