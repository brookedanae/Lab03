using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.Write("Hey, you! What's your name? ");
            string userName = Console.ReadLine();

            do
            {

                bool isInvalidResponse;
            
                do
                {

                    Console.Write("\n" + $"{userName}, enter a number between 1 and 100: ");
                    var userNumber = Console.ReadLine();
                    var outputNumber = int.Parse(userNumber);

                    if (outputNumber % 2 == 0 && outputNumber >= 2 && outputNumber <= 25)
                    {
                        Console.WriteLine("\n" + $"Output: {userNumber}, Even and less than 25!");
                    }
                    else if (outputNumber % 2 == 0 && outputNumber >= 26 && outputNumber <= 60)
                    {
                        Console.WriteLine("\n" + $"Output: {userNumber}, Even!");
                    }
                    else if (outputNumber % 2 == 0 && outputNumber >= 60 && outputNumber <= 100)
                    {
                        Console.WriteLine("\n" + $"Output: {userNumber}, Even!");
                    }
                    else if (outputNumber % 2 != 0 && outputNumber >= 60 && outputNumber < 100)
                    {
                        Console.WriteLine("\n" + $"Output: {userNumber}, Odd!");
                    }
                    else if (outputNumber <= 0 || outputNumber >= 101)
                    {
                        Console.WriteLine("\n" + $"Whoa, {userName}! The number HAS to be between 1 and 100!");
                    }
                    else if (outputNumber % 2 != 0 && outputNumber >= 1 && outputNumber < 100)
                    {
                        Console.WriteLine("\n" + $"Output: {userNumber}, Odd!");
                    }

                    Console.Write("\n" + $"{userName}, do you want to continue? (y/n): ");
                    response = Console.ReadLine();
                    isInvalidResponse = response != "y" && response != "n";
                    if (isInvalidResponse)
                    {
                        Console.WriteLine($"Oops! You need to enter 'y' or 'n', {userName}!" + "\n");
                    }
                } while (isInvalidResponse);


            } while (response == "y");

            Console.WriteLine($"Thanks for playing, {userName}! Have a great day :)");


        }
    }
}