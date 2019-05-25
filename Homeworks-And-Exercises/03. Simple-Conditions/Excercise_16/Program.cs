using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string numbersAsWord = string.Empty;

            if (number < 0 || number > 100)
            {
                numbersAsWord="invalid number";
            }
            else if(number ==100)
            {
                numbersAsWord = "one hundred";
            }

            else if (number < 20)
            {
                switch (number)
                {
                    case 0:
                        numbersAsWord += "zero";
                        break;
                    case 1:
                        numbersAsWord += "one";
                        break;
                    case 2:
                        numbersAsWord += "two";
                        break;
                    case 3:
                        numbersAsWord += "three";
                        break;
                    case 4:
                        numbersAsWord += "four";
                        break;
                    case 5:
                        numbersAsWord += "five";
                        break;
                    case 6:
                        numbersAsWord += "six";
                        break;
                    case 7:
                        numbersAsWord += "seven";
                        break;
                    case 8:
                        numbersAsWord += "eight";
                        break;
                    case 9:
                        numbersAsWord += "nine";
                        break;
                    case 10:
                        numbersAsWord += "ten";
                        break;
                    case 11:
                        numbersAsWord += "eleven";
                        break;
                    case 12:
                        numbersAsWord += "twelve";
                        break;
                    case 13:
                        numbersAsWord += "thirteen";
                        break;
                    case 14:
                        numbersAsWord += "fourteen";
                        break;
                    case 15:
                        numbersAsWord += "fifteen";
                        break;
                    case 16:
                        numbersAsWord += "sixteen";
                        break;
                    case 17:
                        numbersAsWord += "seventeen";
                        break;
                    case 18:
                        numbersAsWord += "eighteen";
                        break;
                    case 19:
                        numbersAsWord += "nineteen";
                        break;
                }
            }
            else if (number >= 20 && number < 100)
            {
                int firstDigit = number / 10;
                int lastDigit = number % 10;

                switch (firstDigit)
                {
                    case 2:
                        numbersAsWord += "twenty";
                        break;
                    case 3:
                        numbersAsWord += "thirty";
                        break;
                    case 4:
                        numbersAsWord += "forty";
                        break;
                    case 5:
                        numbersAsWord += "fifty";
                        break;
                    case 6:
                        numbersAsWord += "sixty";
                        break;
                    case 7:
                        numbersAsWord += "seventy";
                        break;
                    case 8:
                        numbersAsWord += "eighty";
                        break;
                    case 9:
                        numbersAsWord += "ninety";
                        break;
                }

                switch (lastDigit)
                {
                    case 1:
                        numbersAsWord += " one";
                        break;
                    case 2:
                        numbersAsWord += " two";
                        break;
                    case 3:
                        numbersAsWord += " three";
                        break;
                    case 4:
                        numbersAsWord += " four";
                        break;
                    case 5:
                        numbersAsWord += " five";
                        break;
                    case 6:
                        numbersAsWord += " six";
                        break;
                    case 7:
                        numbersAsWord += " seven";
                        break;
                    case 8:
                        numbersAsWord += " eight";
                        break;
                    case 9:
                        numbersAsWord += " nine";
                        break;
                }
            }
            Console.WriteLine(numbersAsWord);
        }
    }
}
