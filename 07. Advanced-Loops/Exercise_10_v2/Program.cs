using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if(n%i==0)
                    {
                        Console.WriteLine("Not Prime");
                        return;
                    }
                }
                Console.WriteLine("Prime");
            }
        }
    }
}
