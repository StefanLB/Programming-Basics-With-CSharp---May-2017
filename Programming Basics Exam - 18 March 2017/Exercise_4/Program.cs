using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            decimal totalPoints = 0m;

            int from0to9 = 0;
            int from10to19 = 0;
            int from20to29 = 0;
            int from30to39 = 0;
            int from40to50 = 0;
            int invalidNumbers = 0;

            for (int i = 0; i < moves; i++)
            {
                decimal currentInput = decimal.Parse(Console.ReadLine());

                if (currentInput >= 0 && currentInput <= 9)
                {
                    totalPoints += 0.2m * currentInput;
                    from0to9++;
                }
                else if (currentInput >= 0 && currentInput <= 19)
                {
                    totalPoints += 0.3m * currentInput;
                    from10to19++;
                }
                else if (currentInput >= 0 && currentInput <= 29)
                {
                    totalPoints += 0.4m * currentInput;
                    from20to29++;
                }
                else if (currentInput >= 0 && currentInput <= 39)
                {
                    totalPoints += 50m;
                    from30to39++;
                }
                else if (currentInput >= 0 && currentInput <= 50)
                {
                    totalPoints += 100m;
                    from40to50++;
                }
                else
                {
                    totalPoints /= 2m;
                    invalidNumbers++;
                }
            }

            Console.WriteLine($"{totalPoints:f2}");
            Console.WriteLine($"From 0 to 9: {(((decimal)from0to9 / moves) * 100):f2}%");
            Console.WriteLine($"From 10 to 19: {(((decimal)from10to19 / moves) * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {(((decimal)from20to29 / moves) * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {(((decimal)from30to39 / moves) * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {(((decimal)from40to50 / moves) * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(((decimal)invalidNumbers / moves) * 100):f2}%");

        }
    }
}
