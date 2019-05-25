using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            string sizeOfDrink = Console.ReadLine();
            int numberOfDrinks = int.Parse(Console.ReadLine());

            decimal priceOfWatermelon = 56.00m*2;
            decimal priceOfMango = 36.66m*2;
            decimal priceOfPineapple = 42.10m*2;
            decimal priceOfRaspberry = 20.00m*2;
            
            if(sizeOfDrink=="big")
            {
                priceOfWatermelon = 28.70m*5;
                priceOfMango = 19.60m*5;
                priceOfPineapple = 24.80m*5;
                priceOfRaspberry = 15.20m*5;
            }

            decimal totalPrice = 0m;

            if(typeOfDrink== "Watermelon")
            {
                totalPrice = numberOfDrinks * priceOfWatermelon;
            }
            else if(typeOfDrink == "Mango")
            {
                totalPrice = numberOfDrinks * priceOfMango;
            }
            else if (typeOfDrink == "Pineapple")
            {
                totalPrice = numberOfDrinks * priceOfPineapple;
            }
            else if (typeOfDrink == "Raspberry")
            {
                totalPrice = numberOfDrinks * priceOfRaspberry;
            }

            if(totalPrice>1000)
            {
                totalPrice *= 0.5m;
            }
            else if(totalPrice>=400 && totalPrice<=1000)
            {
                totalPrice *= 0.85m;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");

        }
    }
}
