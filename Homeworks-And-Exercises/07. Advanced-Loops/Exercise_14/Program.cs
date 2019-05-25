using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int print = 1;

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++,print++)
                {
                    if (print<=input)
                    {
                        Console.Write($"{print} ");
                    }
                    else
                    {
                        Console.Write($"{2*input-print} ");
                    }
                }
                print = 1+i;
                Console.WriteLine();
            }
        }

    }
}
