using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*',2*n+1));
            Console.WriteLine($".*{new string(' ',2*n-3)}*.");

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine($"{new string('.',i)}..*{new string('@',2*n-5-2*i)}*..{new string('.', i)}");
            }

            Console.WriteLine($"{new string('.',n)}*{new string('.', n)}");

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine($"{new string('.', (n - 1 - i))}*{new string(' ',i)}@{new string(' ',i)}*{new string('.', (n - 1 - i))}");
            }

            Console.WriteLine($".*{new string('@', 2 * n - 3)}*.");
            Console.WriteLine(new string('*', 2 * n + 1));
        }
    }
}
