using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (input <= 100)
                bonus = 5;
            else if (input <= 1000)
                bonus = input * 0.2;
            else
                bonus = input * 0.1;

            if (input % 2 == 0)
                bonus ++;
            else if (input % 5 == 0)
                bonus += 2;

            Console.WriteLine(bonus);
            Console.WriteLine(bonus+input);



        }
    }
}
