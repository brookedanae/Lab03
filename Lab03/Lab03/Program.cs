using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            do
            {

                bool isInvalidResponse;

                do
                {

                    Console.Write("Enter a number between 1 and 100: ");
                    var userNumber = Console.ReadLine();
                    var outputNumber = int.Parse(userNumber);

                    if (outputNumber % 2 == 0 && outputNumber <= 25)
                    {
                        Console.WriteLine($"Output: {userNumber}, Even and less than 25!");
                    }
                    else if (outputNumber % 2 == 0 && outputNumber <= 60)
                    {
                        Console.WriteLine($"Output: {userNumber}, Even and less than 60!");
                    }
                    else if (outputNumber % 2 == 0)
                    {
                        Console.WriteLine($"Output: {userNumber}, Even!");
                    }
                    else
                    {
                        Console.WriteLine($"Output: {userNumber}, Odd" + "\n");
                    }

                    Console.WriteLine("Continue? (y/n): ");
                    response = Console.ReadLine();
                    isInvalidResponse = response != "y" && response != "n";
                    if (isInvalidResponse)
                    {
                        Console.WriteLine("Oops! You need to enter 'y' or 'n'!" + "\n");
                    }
                } while (isInvalidResponse);


            } while (response == "y");

            Console.WriteLine("Thanks for playing! Goodbye :)");


        }
    }
}