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

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine($"{new string('.',6*n-3-3*i)}{new string('#',1+6*i)}{new string('.', 6 * n - 3 - 3 * i)}");
            }

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine($"|..{new string('.', 3*i)}{new string('#',12*n-11-6*i)}{new string('.', 3 * i)}...");
            }

            for (int i = 0; i < n; i++)
            {
                if (i!=n-1)
                {
                    Console.WriteLine($"|{new string('.',3*n-4)}{new string('#',6*n+1)}{new string('.', 3 * n - 3)}");
                }
                else
                {
                    Console.WriteLine($"@{new string('.', 3 * n - 4)}{new string('#', 6 * n + 1)}{new string('.', 3 * n - 3)}");
                }
            }
        }
    }
}
