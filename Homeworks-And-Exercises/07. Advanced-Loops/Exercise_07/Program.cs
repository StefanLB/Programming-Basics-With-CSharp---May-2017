using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TIME LIMIT for 1 OF THE TESTS
             *int b = int.Parse(Console.ReadLine());
             int smallNum = 0;
             int commonDel = 0;

             if(a>=b)
             {
                 smallNum = a;
             }
             else
             {
                 smallNum = b;
             }

             for (int i = 1; i <= smallNum; i++)
             {
                 if(a%i==0 && b%i==0)
                 {
                     commonDel = i;
                 }
             }

             Console.WriteLine(commonDel);

     */

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            while (b!=0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }

            Console.WriteLine(a);

        }
    }
}
