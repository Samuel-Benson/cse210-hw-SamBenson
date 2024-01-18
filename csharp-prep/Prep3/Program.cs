using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        int count = 5;

        while(count < 10)
            System.Console.WriteLine($"Count = {count++}");
            count++;
        
        while(count < 15)
        {
            System.Console.WriteLine($"Count = {count}");
            count++;
        }

        // do-while loop
        do {
            System.Console.WriteLine($"AnotherCount = {anotherCount++}");
        } while(AnotherCount < 10);
        
        // for loop
        for(int i =0; i<5; i++){
            System.Console.WriteLine($"i = {i}");
        }

       // System.Console.WriteLine($"i = {i}");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        while (!isCorrect){
            System.Console.WriteLine("Guess a random number");
            int guess = int.Parse(Console.ReadLine());

            if (guess > randomNumber) [
                System.Console.WriteLine("Too High");
            ]

            else if (guess < randomNumber) {
                System.Console.WriteLine("Too Low");
            }

            else 
            {
                System.Console.WriteLine("Correct");
                isCorrect = true;
            }
        }
    }
}