using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"a\":"); // With "\\" you tell C# not to interpret the input between as special commands. Here, cmd will write "Enter "a":"
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter \"b\":");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a>b ? "A is greater":"B is greater");  //First if true parameter, then if false parameter

            //int n = in.Parse(Console.ReadLine().Trim()); <- TRIM WILL REMOVE SPACES BEFORE AND AFTER THE INPUT
        }
    }
}
