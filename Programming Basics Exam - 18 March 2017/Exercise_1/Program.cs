using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal side = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{((side*side+side*side/2+(side/2*(height-side/2))-(side/5)*(side/5)))/ 3:f2}");
            Console.WriteLine($"{((side*side)/5):f2}");
        }
    }
}
