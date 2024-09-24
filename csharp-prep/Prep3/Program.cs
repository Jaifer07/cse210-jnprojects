using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
       // int magicNumber = int.Parse(Console.ReadLine());

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 50);

        int guessedNumber = -1;

        while (guessedNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (magicNumber > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessedNumber) 
            { 
                Console.WriteLine("Lower");
            }   
            else 
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }

        
    }
       
    
} 