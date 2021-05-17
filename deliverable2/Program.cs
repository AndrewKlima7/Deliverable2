using System;

namespace deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool one = false;
            string userInput;
            string userInput2;
            while (one == false)
            {
                Console.WriteLine("What would you like to say to the bot?: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "hello")
                {
                    Console.WriteLine("Hi good to see you.");
                }
                else if (userInput.ToLower() == "bye")
                {
                    Console.WriteLine("Good bye!");
                    one = true;
                }
                else if (userInput.ToLower() == "sup")
                {
                    Console.WriteLine("I am good");

                }
                else if (userInput.ToLower() == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                }
                else
                {
                    Console.WriteLine("Please input command that the bot can respond to.");
                }

                Console.WriteLine("What would you like to say to the bot?: ");
                userInput2 = Console.ReadLine();
                
                if (userInput2.ToLower() == userInput.ToLower())
                {
                    Console.WriteLine("I'm sorry but you have already said that.");
                }
                else if (userInput2.ToLower() == "hello")
                {
                    Console.WriteLine("Hi good to see you.");
                } else if (userInput2.ToLower() == "bye")
                {
                    Console.WriteLine("Good bye!");
                    one = true;
                } else if (userInput2.ToLower() == "sup")
                {
                    Console.WriteLine("I am good");
                } else if (userInput2.ToLower() == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                }
                else
                {
                    Console.WriteLine("Please input command that the bot can respond to.");
                }
            }
        }
    }
}
