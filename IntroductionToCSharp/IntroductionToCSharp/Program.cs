using IntroductionToCSharp.CSharpLectures;
using IntroductionToCSharp.DA_Programs;
using System.Runtime.CompilerServices;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Hello, User Please enter your name");
            //string Str = Console.ReadLine();
            //Console.WriteLine("Hello " + Str + " How are you");
            //Console.WriteLine("Hello {Str}  How are you");

            //stringEx();
            //Operator();
            //NullableType();
            //NullCoalescingOperator();

            //DoWhileLoop DWL = new DoWhileLoop();

            //DWL.WhileLoop();

            CombineSortedList combineSortedList = new CombineSortedList();

            List<int> list1 = new List<int>() { 1,2,3,4,5};
            List<int> list2 = new List<int>() { 6,7,8,9,10};



            List<int> mergedList = combineSortedList.MergeSortedList(list1, list2);

            Console.WriteLine("Merged and sorted list: " + "[" + string.Join(", ", mergedList) + "]");

        }

        static public void stringEx()
        {
            Console.WriteLine("\"Hello Number\"");
            Console.WriteLine("One\nTwo\n\\Three\"");
            string mast = @"Hey%%//werwe^^&&88**\\ \\asdjhdgf\asdfa\\";
            Console.WriteLine(mast);
        }

        static public void Operator()
        {
            int n = 10;
            int d = 2;

            int devide = n / d;
            int mod = n % d;
            int mul = n * d;

            Console.WriteLine("Divide = {0}, Modulus = {1}, Multipy  = {2}", devide, mod, mul);

            bool IsNumber10 = n ==10? true : false;

            Console.WriteLine("Number is 10 {0}", IsNumber10);
        }

        static public void NullableType()
        {
            int i = 0; // it is correct

            //int j = null; // We can't make directly value type as null

            int? j = null;

            bool? AreYouMajor = null;
            Console.WriteLine("Hi User, Are you Major?");

            string Ans = Console.ReadLine();

            AreYouMajor = Ans == "y" || Ans == "Yes" || Ans == "Y" || Ans == "yes"? true : Ans == ""? null: false;
            string result = AreYouMajor == true ? "User Is Major" : AreYouMajor == null? "User Did not answer": "User Is Minor";

            Console.WriteLine(result);
        }

        static void NullCoalescingOperator()
        {
            int? TicketsOnSale = null;

            //int AvailableTickets;

            //if(TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = TicketsOnSale.Value;
            //}

            //The above lines can rewritten as below single line;

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("Available Tickets = {0}", AvailableTickets);
        }

        static void DataTypeConversion()
        {
            // implicit conversion
            int i = 100;
            float f = i;
            Console.WriteLine(f);

            // Explicit conversion
            float x = 12.23F;
            int y = (int)x; // it is work only for small number
            int z = Convert.ToInt32(x); // if is going larger then the limit then we will exception
            Console.WriteLine(y);

            string s = "100";
            int a = Convert.ToInt32(s);
            int b = int.Parse(s); // this give error if input is "100ty"
            int r = 0;
            bool IsConversionSuccessfull = int.TryParse(s,out r);

            if (IsConversionSuccessfull)
            {
                Console.WriteLine(r);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }



        }

        static void Arrays()
        {
            int i = 10;

            int[] exampleArray = new int[4];    
            exampleArray[0] = i;
            exampleArray[1] = i;
            object[] exampleArray2 = new object[4];

        }

        static void IfElse()
        {
            Console.WriteLine("Please Enter a Number");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("This num is zero");
            }

            else if (num == 1)
            {
                Console.WriteLine("This num is one");
            }

            else
            {
                Console.WriteLine("Num out of range");
            }
        }

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
                    break ;
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
                default :
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
