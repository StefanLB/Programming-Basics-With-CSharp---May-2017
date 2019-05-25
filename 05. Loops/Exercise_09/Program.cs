using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int textLength = input.Length-1;
            int totalPoints = 0;

            for (int i = 0; i <= textLength; i++)
            {
                char symbol = input[i];

                switch(symbol)
                {
                    case 'a':
                        totalPoints += 1;
                        break;

                    case 'e':
                        totalPoints += 2;
                        break;

                    case 'i':
                        totalPoints += 3;
                        break;

                    case 'o':
                        totalPoints += 4;
                        break;

                    case 'u':
                        totalPoints += 5;
                        break;

                    default:
                        break;

                }
            }
            Console.WriteLine(totalPoints);
        }
    }
}
