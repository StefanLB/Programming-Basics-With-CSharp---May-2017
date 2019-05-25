using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            while(n!=0)
            {
                sumOfDigits += n % 10;
                n /= 10;
            }

            Console.WriteLine(sumOfDigits);

        }
    }
}
