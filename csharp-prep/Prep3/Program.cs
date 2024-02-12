using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        int userGuess = 0;

        do
        {
            Console.WriteLine("What is your guess between 1 and 100? ");
            string secondInput = Console.ReadLine();
            userGuess = int.Parse(secondInput);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You got it!");
            }
        
        } while (userGuess != magicNumber);
       
    }
}