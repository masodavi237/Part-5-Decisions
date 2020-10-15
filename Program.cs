using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5_Decisions
{
    class Program
    {

        

        static void EnterToCont()
        {
            Console.WriteLine("Press ENTER to Continue:");
            Console.ReadLine();
        }

        static void Age()
        {
            int age;
            string user;

            Console.WriteLine("Please enter your age:");
            user = Console.ReadLine();

            if (Int32.TryParse(user, out age))
            {
                if (age > 18)
                {
                    Console.WriteLine("You are an adult.");
                }
                else if (age <= 18 && age >= 0)
                {
                    if (age <= 5)
                    {
                        Console.WriteLine("Yu are a toddler.");
                    }
                    else if (age <= 10 && age > 5)
                    {
                        Console.WriteLine("You are a child.");
                    }
                    else if (age <= 12 && age > 10)
                    {
                        Console.WriteLine("You are a preteen.");
                    }
                    else if (age > 12)
                    {
                        Console.WriteLine("You are a teen");
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                        EnterToCont();
                        Age();
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                    EnterToCont();
                    Age();
                }
            }
            else
            {
                Console.WriteLine("Please retry and enter another age. TIP: make sure that the input only includes numbers!");
                EnterToCont();
                Age();
            }

            EnterToCont();
            Choice();

        }

        static void Hurricane()
        {
            int cat;
            string user;

            Console.WriteLine("What category is the Hurricane?");
            user = Console.ReadLine();

            if (Int32.TryParse(user, out cat))
            {
                switch (cat)
                {
                    case 1:
                        Console.WriteLine("According to the Saffir-Simpsons Hurricane Scale, the wind speeds for a Category 1 Hurricane are:");
                        Console.WriteLine("74-95 mph or 64-82 kt or 119-153 km/hr");
                        break;
                    case 2:
                        Console.WriteLine("According to the Saffir-Simpsons Hurricane Scale, the wind speeds for a Category 2 Hurricane are:");
                        Console.WriteLine("96-110 mph or 83-95 kt or 154-177 km/hr");
                        break;
                    case 3:
                        Console.WriteLine("According to the Saffir-Simpsons Hurricane Scale, the wind speeds for a Category 3 Hurricane are:");
                        Console.WriteLine("111-130 mph or 96-113kt or 178-209 km/hr");
                        break;
                    case 4:
                        Console.WriteLine("According to the Saffir-Simpsons Hurricane Scale, the wind speeds for a Category 4 Hurricane are:");
                        Console.WriteLine("131-155 mph or 114-135 kt or 210-249 km/hr");
                        break;
                    case 5:
                        Console.WriteLine("According to the Saffir-Simpsons Hurricane Scale, the wind speeds for a Category 5 Hurricane are:");
                        Console.WriteLine("Greater than 155 mph or 135 kt or 249 km/hr");
                        break;
                    default:
                        Console.WriteLine("That is an unknown category. The Saffir-Simpson Scale ranges from 1-5 inclusive.");
                        EnterToCont();
                        Hurricane();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unable to process input. TIP: make sure that the input only includes numbers!");
                EnterToCont();
                Age();

            }
            EnterToCont();
            Choice();
        }

        static void RandomNumber()
        {
            Random generator = new Random();
            int random;
            string input;
            int divisor;

            random = generator.Next(2, 7);

            Console.WriteLine($"The number is {random}. Please enter an integer that is larger than {random}.");
            input = Console.ReadLine();

            if (Int32.TryParse(input, out divisor) && (divisor > random))
            {
                if ((divisor % random) == 0)
                {
                    int answer;
                    answer = divisor / random;
                    Console.WriteLine($"{divisor} IS divisable by {random}");
                    Console.WriteLine($"This gives an answer of {answer}");
                }
                else
                {
                    double answer;
                    answer = (double)divisor / random;
                    Console.WriteLine($"{divisor} is NOT divisible by {random}");
                    Console.WriteLine($"This gives an answer of {answer}");
                }
            }

            else
            {
                Console.WriteLine("Unable to process input.");
                Console.WriteLine("---TIP: make sure that the input only includes numbers!---");
                Console.WriteLine("---TIP: make sure that the input is larger than the number provided!---");
                EnterToCont();
                RandomNumber();
            }

            EnterToCont();
            Choice();
        }

        static void Choice()
        {
            string goTo;
            int intGoTo;

            Console.WriteLine("1 ---> Age");
            Console.WriteLine("2 ---> Hurricane");
            Console.WriteLine("3 ---> RandomNumber");
            Console.WriteLine("9 ---> Quit");
            goTo = Console.ReadLine();

            if (Int32.TryParse(goTo, out intGoTo))
            {
                switch (intGoTo)
                {
                    case 1:
                        Age();
                        break;

                    case 2:
                        Hurricane();
                        break;

                    case 3:
                        RandomNumber();
                        break;

                    case 9:
                        break;

                    default:
                        Console.WriteLine("Invalid entry. Please enter a number from 1-3 inclusive.");
                        EnterToCont();
                        Choice();
                        break;
                }

            }

            else
            {
                Console.WriteLine("Invalid entry. Please enter a number from 1-3 inclusive.");
                EnterToCont();
                Choice();
            }
        }

        static void Main(string[] args)
        {

            Choice();
            

        }
    }
}
