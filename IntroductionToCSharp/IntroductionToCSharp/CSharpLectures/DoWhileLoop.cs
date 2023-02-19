using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp.CSharpLectures
{
    internal class DoWhileLoop
    {
        public void WhileLoop()
        {
            Console.WriteLine("Please enter the target number");
            int target = int.Parse(Console.ReadLine());

            int start = 0;
            string userChoice = "";
            do
            { 
                while (start <= target)
                {
                    Console.Write(start++ + " ");
                    Console.WriteLine(start);
                    start += 2;
                }

                do
                { 
                    /// Here we want ask to continue
                    Console.WriteLine("Do you want to continue? -> y | n");

                    /// But in this we wanted ask this untill we are not getting the correct choice from the user
                    userChoice =  Console.ReadLine().ToLower();
                    if (userChoice != "y" && userChoice != "n")
                    {
                        Console.WriteLine("Invalid choice! Please say y | n");
                    }
                }
                while (userChoice != "y" && userChoice != "n");
            } while (userChoice == "y");

        }
    }
}
