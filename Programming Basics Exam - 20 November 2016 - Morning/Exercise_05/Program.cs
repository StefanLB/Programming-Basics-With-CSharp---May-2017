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
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('*',i)}\\{new string('-',width-2-2*i)}/{new string('*', i)}");
            }

            decimal ochi = Math.Floor(n / 3m);

            for (int i = 0; i < ochi; i++)
            {
                Console.WriteLine($"|{new string('*',((width-n-4)/2+i))}\\{new string('*',(n-2*i))}/{new string('*', ((width - n - 4) / 2 + i))}|");
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{new string('-', i)}\\{new string('*', width - 2 - 2 * i)}/{new string('-', i)}");
            }

        }
    }
}
