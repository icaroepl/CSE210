using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);     
        int numberGuess = 0;
        int guesses = 1;
        
        while (numberGuess != randomNumber){
            Console.Write("Guess the random number ");
            string guessText = Console.ReadLine();
            numberGuess = int.Parse(guessText);
            if (numberGuess > randomNumber)
            {
                Console.WriteLine("lower");
            }
            else if (numberGuess < randomNumber)
            {
                Console.WriteLine("Higher");       
            }       
            guesses += 1;    
        }
        Console.Write($"You guessed it with {guesses} attempts");         
    }
}