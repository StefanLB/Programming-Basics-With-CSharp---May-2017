using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++,m++)
                {
                    if(m>n)
                    {
                        return;
                    }
                    Console.Write($"{m} ");
                }
                Console.WriteLine();
            }

        }
    }
}
