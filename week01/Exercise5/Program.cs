using System;
using System.Globalization;

class Program
{
    static void DisplayResult(string usersName, int numberSquared)
    {
        Console.WriteLine($"{usersName}, the square of your number is {numberSquared}");
    }
    static int SquareNumber(int intNumber)
    {
        int numberSquared = intNumber * intNumber;
        return numberSquared;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string sNumber = Console.ReadLine();   
        int intNumber = int.Parse(sNumber);
        return intNumber;     
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string usersName = Console.ReadLine();
        return usersName;
    }
    static void DisplayWelcome() 
    {
        Console.WriteLine("Welcome to the program!");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();
        string usersName = PromptUserName();
        int intNumber = PromptUserNumber();
        int numberSquared = SquareNumber(intNumber);
        DisplayResult(usersName, numberSquared);
    }
}

/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name and the squared number and displays them.


Welcome to the program!
Please enter your name: Brother Burton
Please enter your favorite number: 42
Brother Burton, the square of your number is 1764

*/