using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var input2 = double.Parse(Console.ReadLine());

            if(input>=input2)
                Console.WriteLine(input);
            else
                Console.WriteLine(input2);


        }
    }
}
