using System;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        Random magicNumber = new Random();
        int number = magicNumber.Next(1, 100);
        string guess = "";
        int i = 0;

        bool status = true;
        do
        {
            Console.WriteLine($"The magic number is: {number}");

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();

            int guessedNumber = int.Parse(guess);

            if (guessedNumber == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"Number of guesses: {i}");
                Console.WriteLine("");
                Console.Write("Would you like to play again? (yes or no) ");
                string answer = Console.ReadLine();
                if (answer != "yes" && answer != "no")
                {
                    Console.Write("Please choose a valid option: (yes or no) ");
                    answer = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (answer == "yes")
                    {
                        number = magicNumber.Next(1, 100);
                        continue;
                    }
                    else if (answer == "no")
                    {
                        return;
                    }
                }

            }
            else
            {
                if (guessedNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            }
            i++;
            
        }while (status == true);

        Console.WriteLine("See you soon!");
    }
}
