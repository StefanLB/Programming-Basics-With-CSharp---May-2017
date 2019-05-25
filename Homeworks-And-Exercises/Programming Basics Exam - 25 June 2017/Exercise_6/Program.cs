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
            int n = int.Parse(Console.ReadLine());
            bool anyMatches = false;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if((i+j+k)==n && i<j && j<k)
                        {
                            Console.WriteLine($"{i} + {j} + {k} = {n}");
                            anyMatches = true;
                        }
                        else if((i * j * k) == n && i > j && j > k)
                        {
                            Console.WriteLine($"{i} * {j} * {k} = {n}");
                            anyMatches = true;
                        }
                    }
                }
            }
            if(anyMatches==false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
