using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int youngPeople = int.Parse(Console.ReadLine());
            int numOfStays = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            decimal ticketPriceOld = 0m;
            decimal ticketPriceYoung = 0m;

            if (transport == "train" && (oldPeople + youngPeople) >= 50)
            {
                ticketPriceOld = 24.99m / 2;
                ticketPriceYoung = 14.99m / 2;
            }
            else if (transport == "train")
            {
                ticketPriceOld = 24.99m;
                ticketPriceYoung = 14.99m;
            }
            else if (transport == "bus")
            {
                ticketPriceOld = 32.50m;
                ticketPriceYoung = 28.50m;
            }
            else if (transport == "boat")
            {
                ticketPriceOld = 42.99m;
                ticketPriceYoung = 39.99m;
            }
            else if (transport == "airplane")
            {
                ticketPriceOld = 70m;
                ticketPriceYoung = 50m;
            }

            decimal totalPrice = (numOfStays * 82.99m + oldPeople * ticketPriceOld * 2 + youngPeople * ticketPriceYoung * 2) * 1.1m;

            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
