using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var even = double.Parse(Console.ReadLine());

                if(even%2==0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");


        }
    }
}
