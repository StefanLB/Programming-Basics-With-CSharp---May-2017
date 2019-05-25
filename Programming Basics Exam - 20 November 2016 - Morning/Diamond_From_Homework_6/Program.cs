using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_From_Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Ceiling(n / 2.0); i++)
            {
                if (n % 2 == 0)
                {
                    if(i==0)
                    {
                    Console.WriteLine("{0}**{0}", new string('-', (n / 2)-1));
                    }
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - 1) / 2) - i), new string('-', 2 * i));
                    }



                }
                else if (n % 2 != 0)
                {
                    if(i==0)
                    {
                    Console.WriteLine("{0}*{0}", new string('-', (n - 1) / 2));
                    }
                    else
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - 1) / 2) - i), new string('-',2 * i-1));
                    }

                }
            }

            for (double i = Math.Ceiling(n / 2.0) - 1; i >= 0; i--)
                {
                Console.WriteLine("{0}{1}{0}",new string('-',), new string('-',n-2*((n-1)/2)-2));


                }





        }
    }
}
