using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"{0.675395:P2}");
            decimal car = 0m;
            decimal microBus = 0m;
            decimal smallBus = 0m;
            decimal bigBus = 0m;
            decimal train = 0m;

            int numberOfGroups = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfGroups; i++)
            {
                int peopleInCurrentGroup = int.Parse(Console.ReadLine());

                if (peopleInCurrentGroup <= 5)
                {
                    car += peopleInCurrentGroup;
                }
                else if (peopleInCurrentGroup <= 12)
                {
                    microBus += peopleInCurrentGroup;
                }
                else if (peopleInCurrentGroup <= 25)
                {
                    smallBus += peopleInCurrentGroup;
                }
                else if (peopleInCurrentGroup <= 40)
                {
                    bigBus += peopleInCurrentGroup;
                }
                else if (peopleInCurrentGroup > 40)
                {
                    train += peopleInCurrentGroup;
                }
            }

            decimal totalPeople = car + microBus + smallBus + bigBus + train;

            Console.WriteLine($"{(car / totalPeople * 100):F2}%");
            Console.WriteLine($"{(microBus / totalPeople * 100):F2}%");
            Console.WriteLine($"{(smallBus / totalPeople * 100):F2}%");
            Console.WriteLine($"{(bigBus / totalPeople * 100):F2}%");
            Console.WriteLine($"{(train / totalPeople * 100):F2}%");

        }
    }
}
