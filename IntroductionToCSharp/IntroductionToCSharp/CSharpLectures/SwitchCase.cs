using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp.CSharpLectures
{
    internal class SwitchCase
    {
        static void SwitchStatment()
        {
            Console.WriteLine("Please Enter a Number");
            int num = int.Parse(Console.ReadLine());

            if (num == 10)
            {
                Console.WriteLine("This num is 10");
            }

            else if (num == 20)
            {
                Console.WriteLine("This num is 20");
            }

            else if (num == 30)
            {
                Console.WriteLine("This num is 30");
            }

            else
            {
                Console.WriteLine("Num out of range");
            }

            // To implement above logic we can use the switch statement as shown below:

            switch (num)
            {
                case 10:
                    Console.WriteLine("This num is 10");
                    break;
                case 20:
                    Console.WriteLine("This num is 20");
                    break;
                case 30:
                    Console.WriteLine("This num is 10");
                    break;
                default:
                    Console.WriteLine("Num out of range");
                    break;
            }

            // We can further simply the things using switch
            switch (num)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("This num is {0}", num);
                    break;
                default:
                    Console.WriteLine("Num out of range");
                    break;
            }

            // We will write a coffee machine algo using switch 

            int coffeeCost = 0;

        Start:
            Console.WriteLine("1 -> Small, 2 -> Medium, 3 -> Large");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    coffeeCost += 50;
                    break;
                case 2:
                    coffeeCost += 100;
                    break;
                case 3:
                    coffeeCost += 150;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid", userChoice);
                    break;

            }

        Decide:
            Console.WriteLine("Do you want another coffee? y or n");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToLower())
            {
                case "y":
                    goto Start;
                case "n":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again...", userDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank you for shopping with us /n Total cost is {0}", coffeeCost);

        }
    }
}
