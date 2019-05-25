using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            char fourthChar = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            char i = 'A';
            char j = 'a';
            char k = 'a';
            char l = 'a';
            int m = 0;

            int combos = 0;

            for ( i = 'A'; i <= firstChar; i++)
            {
    
                for ( j = 'a'; j <= secondChar; j++)
                {
                   
                    for ( k = 'a'; k <= thirdChar; k++)
                    {
                      
                        for ( l = 'a'; l <= fourthChar; l++)
                        {
                           
                            for ( m = 0; m <= num; m++)
                            {
                                if(firstChar==i && secondChar ==j && thirdChar == k && fourthChar ==l && num == m)
                                {
                                    Console.WriteLine(combos);
                                    return;
                                }
                                combos++;
                            }
                        }
                    }
                }
            }

        }
    }
}
