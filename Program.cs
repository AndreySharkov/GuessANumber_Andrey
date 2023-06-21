﻿namespace GuessTheNum
{
    internal class Program
    {//
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            while(true)
            {
                Console.WriteLine("Guess a number (1-100)");
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);
                if(isValid )
                {
                    if(playerNumber == computerNumber )
                    {
                        Console.WriteLine("You guessed it!");
                        break;
                    }
                    else if(playerNumber > computerNumber )
                    {
                        Console.WriteLine("Too high");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input.");

                }
            }

        }
    }
}