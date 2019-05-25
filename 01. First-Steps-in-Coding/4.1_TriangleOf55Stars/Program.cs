using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int StarNumber=0;
            string Stars = "*";
            for (StarNumber=0;StarNumber<=10; StarNumber = StarNumber + 1)
            {
                Console.WriteLine(Stars);
                Stars = Stars + "*";
            }
        }
    
    }
}
