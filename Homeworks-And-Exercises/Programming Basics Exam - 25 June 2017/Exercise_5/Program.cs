using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('#',4*n+1));

            for (int i = 1; i <= n; i++)
            {
                if (i != (n / 2) + 1)
                {
                    Console.WriteLine($"{new string('.',i)}{new string('#',2*n+1-2*i)}{new string(' ',2*i-1)}{new string('#', 2 * n+1 - 2 * i)}{new string('.',i)}");
                }
                else
                {
                    Console.WriteLine($"{new string('.', i)}{new string('#', 2 * n + 1 - 2 * i)}{new string(' ', ((2 * i - 1)/2)-1)}(@){new string(' ', ((2 * i - 1) / 2) - 1)}{new string('#', 2 * n +1 - 2 * i)}{new string('.', i)}");
                }
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('.',n+i)}{new string('#',(2*n+1)-2*i)}{new string('.',n+i)}");
            }

        }
    }
}
