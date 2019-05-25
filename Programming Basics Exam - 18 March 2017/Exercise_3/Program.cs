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
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            decimal budgetSpent = 0m;

            string typeOfCar = "";
            string typeOfClass = "";

            if (budget <= 100)
            {
                typeOfClass = "Economy class";

                if (season == "Summer")
                {
                    typeOfCar = "Cabrio";
                    budgetSpent = 0.35m * budget;
                }
                else if (season == "Winter")
                {
                    typeOfCar = "Jeep";
                    budgetSpent = 0.65m * budget;
                }
            }
            else if (budget <= 500)
            {
                typeOfClass = "Compact class";

                if (season == "Summer")
                {
                    typeOfCar = "Cabrio";
                    budgetSpent = 0.45m * budget;
                }
                else if (season == "Winter")
                {
                    typeOfCar = "Jeep";
                    budgetSpent = 0.8m * budget;
                }
            }
            else if (budget > 500)
            {
                typeOfClass = "Luxury class";
                typeOfCar = "Jeep";
                budgetSpent = 0.9m * budget;
            }

            Console.WriteLine(typeOfClass);
            Console.WriteLine($"{typeOfCar} - {budgetSpent:f2}");
        }
    }
}
