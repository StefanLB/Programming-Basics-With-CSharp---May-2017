using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsFirstPlayer = int.Parse(Console.ReadLine());
            int pokemonsSecondPlayer = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int battlesFought = 0;

            for (int i = 1; i <= pokemonsFirstPlayer; i++)
            {
                    for (int k = 1; k <= pokemonsSecondPlayer; k++)
                    {
                        if (battlesFought < maxBattles)
                        {
                            Console.Write($"({i} <-> {k}) ");
                            battlesFought++;
                        }
                    }
            }
        }
    }
}
