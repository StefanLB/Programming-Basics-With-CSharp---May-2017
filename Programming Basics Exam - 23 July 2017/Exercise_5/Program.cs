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
            //Shirina = 5*n

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n+1; i++)
            {
                if (i < n / 2)
                {
                    Console.WriteLine($"{new string('.', n + i)}{new string('#', 3 * n - 2 * i)}{new string('.', n + i)}");
                }
                else
                {
                    Console.WriteLine($"{new string('.', n + i)}#{new string('.', 3 * n - 2 * i-2)}#{new string('.', n + i)}");
                }
            }

            Console.WriteLine($"{new string('.',2*n)}{new string('#',n)}{new string('.',2*n)}");

            for (int i = 0; i < n+2; i++)
            {
                if (i==n/2)
                {
                    Console.WriteLine($"{new string('.',2*n+n/2-5)}D^A^N^C^E^{new string('.',2 * n + n / 2 - 5)}");
                }
                else
                {
                    Console.WriteLine($"{new string('.', 2 * n - 2)}{new string('#', n + 4)}{new string('.', 2 * n - 2)}");
                }
            }

        }
    }
}
