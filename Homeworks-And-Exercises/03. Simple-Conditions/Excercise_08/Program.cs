using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var convertFrom = Console.ReadLine();
            var convertTo = Console.ReadLine();
            double convertedFrom = 0;
            double convertedTo = 0;
            double result = 0;

            if (convertFrom == "mm")
                convertedFrom = 1000;
            else if (convertFrom == "cm")
                convertedFrom = 100;
            else if (convertFrom == "mi")
                convertedFrom = 0.000621371192;
            else if (convertFrom == "in")
                convertedFrom = 39.3700787;
            else if (convertFrom == "km")
                convertedFrom = 0.001;
            else if (convertFrom == "ft")
                convertedFrom = 3.2808399;
            else if (convertFrom == "yd")
                convertedFrom = 1.0936133;

            if (convertTo == "mm")
                convertedTo = 1000;
            else if (convertFrom == "cm")
                convertedTo = 100;
            else if (convertFrom == "mi")
                convertedTo = 0.000621371192;
            else if (convertFrom == "in")
                convertedTo = 39.3700787;
            else if (convertFrom == "km")
                convertedTo = 0.001;
            else if (convertFrom == "ft")
                convertedTo = 3.2808399;
            else if (convertFrom == "yd")
                convertedTo = 1.0936133;

            result = Math.Round((input / convertedFrom * convertedTo), 8);
            
            Console.WriteLine(result);
        }
    }
}
