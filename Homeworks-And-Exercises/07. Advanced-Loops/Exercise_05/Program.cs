using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oldNum = 1;
            int newNum = 0;

            while (n >= newNum)
            {
                Console.WriteLine(oldNum);
                newNum = oldNum * 2 + 1;
                oldNum = newNum;
            }


        }
    }
}
