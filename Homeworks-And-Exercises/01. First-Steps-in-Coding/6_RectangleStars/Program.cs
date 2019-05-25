using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_RectangleStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var nlength = 0;
            string Star = "";
            string Space = "";

            for(nlength=2;nlength<n;nlength = nlength+1)
            {
                Star = Star + "*";
                Space = Space + " ";
            }

            Console.WriteLine("*" + Star + "*");

            for (nlength=2;nlength<n;nlength = nlength+1)
            {
                Console.WriteLine("*" + Space + "*");
            }

            Console.WriteLine("*" + Star + "*");
        }
    }
}
