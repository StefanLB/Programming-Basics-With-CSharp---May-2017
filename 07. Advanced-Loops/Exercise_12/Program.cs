using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oldNum = 0;
            double newNum = 1;

            for (int i = 0; i < n; i++)
            {
                newNum += oldNum;
                oldNum = newNum - oldNum;
            }
            Console.WriteLine(newNum);
        }
    }
}
