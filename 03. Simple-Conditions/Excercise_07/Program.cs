using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());
            var total = firstTime + secondTime + thirdTime;
            var result = "0";

            if (total < 10)
                result = "0:" + "0" + total;
            else if (total < 60)
                result = "0:" + total;
            else if (total < 70)
                result = "1:0" + (total - 60);
            else if (total < 120)
                result = "1:" + (total - 60);
            else if (total < 130)
                result = "2:0" + (total - 120);
            else
                result = "2:" + (total - 120);

            Console.WriteLine(result);



        }
    }
}
