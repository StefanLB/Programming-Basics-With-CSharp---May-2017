using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numSteps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int daysToLearn = int.Parse(Console.ReadLine());

            decimal percentStepsToLearn = Math.Ceiling((((decimal)numSteps / daysToLearn)/numSteps)*100);

            if (percentStepsToLearn>13)
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required { percentStepsToLearn/dancers:f2}% steps to be learned per day.");
            }
            else if(percentStepsToLearn<=13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentStepsToLearn/dancers:f2}%.");
            }
        }
    }
}
