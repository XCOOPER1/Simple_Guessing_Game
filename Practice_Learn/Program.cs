using System;
using System.Linq;
using System.Security.Authentication;

namespace Basics
{
    class Learning
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            

           int targetNumber = random.Next(1, 101);

           int attempts = 0;
             
           bool gameOver = false;

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and  100. What is it?");

            while (!gameOver)
            {

                Console.WriteLine("Enter your guess: ");
                String playerGuess = Console.ReadLine();
                int guess = Convert.ToInt32(playerGuess);

                attempts++;
                
                if (guess == targetNumber)
                {
                    Console.WriteLine("Congrat's! You win " + "You guess the number in " + attempts + " attemps.");

                    gameOver = true;

                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }
            }

            Console.WriteLine("Thanks for playing the Guessing Game!");

            Console.ReadKey();
        }
    }
}
