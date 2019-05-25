using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            if(n<=0)
            {
                Console.WriteLine("Not Prime");
            }
            else if(n==2)
            {
                Console.WriteLine("Prime");
            }
            else if(n==1 || (n%2==0 && n!=2))
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 3; i <= n / 2; i += 2)
                {
                    if (n % i == 0)
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
