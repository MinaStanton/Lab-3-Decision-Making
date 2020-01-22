//Mina Stanton
//January 22, 2020
//Program Description: This program will ask a user to enter an integer between 1 and 100 and it will print out various responses. 

using System;

namespace Lab3_DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int userNumber;
            string userContinue = "y", name;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello there and welcome to Odd or Even! \n");
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            while (userContinue == "y")
            {
                Console.WriteLine($"\nAlright {name}, please enter an integer between 1 and 100.");
                userNumber = int.Parse(Console.ReadLine());

                while (userNumber < 1 || userNumber > 100)
                {
                    Console.WriteLine($"\nInvalid Entry {name}, please enter a POSITIVE integer between 1 and 100.");
                    userNumber = int.Parse(Console.ReadLine());
                }

                if (userNumber % 2 == 0)
                {
                    if (userNumber >= 2 && userNumber <= 25)
                    {
                        Console.WriteLine($"\nHey {name}, your number is Even and less than 25");
                    }
                    else if (userNumber >= 26 && userNumber <= 60)
                    {
                        Console.WriteLine($"\nHey {name}, your number is Even");
                    }
                    else
                    {
                        Console.WriteLine($"\nHey {name}, your number is Even");
                    }
                }
                else
                {
                    Console.WriteLine($"\nHey {name}, your number {userNumber} is Odd");

                }

                
                Console.WriteLine($"\n{name}, would you like to go again? (y/n)");
                userContinue = Console.ReadLine().ToLower(); 

                while(userContinue != "y" && userContinue != "n")
                {
                    Console.WriteLine($"\nInvalid Entry {name}! Would you like to go again? (y/n)");
                    userContinue = Console.ReadLine().ToLower();
                }

                if(userContinue == "n")
                {
                    Console.WriteLine($"\nThat's ok {name}, thanks for playing! BYE!!");
                    break;
                }
            }
        }
    }
}
