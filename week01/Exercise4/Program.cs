using System;
using System.Data;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables and Lists
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int userNumber = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop as long as the input is not 0 and append it to the list
        do
        {
            Console.Write("Enter number: ");
            string stringNumber = Console.ReadLine();
            userNumber = int.Parse(stringNumber);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            else
            {
                continue;
            }

        }while (userNumber != 0);

        // Initialize variables needed for data formatting
        float count = 0;
        float highestNumber = 0;
        float smallestNumber = 100000;

        // Find highest and lowest numbers in the list 
        foreach (int number in numbers)
        {
            count += number;
            if (number > highestNumber)
            {
                highestNumber = number;
            }
            if (number < smallestNumber)
            {
                smallestNumber = number;
            }
        }

        // Display formatted data
        float averageNumber = count / numbers.Count;
        Console.WriteLine($"The average is: {averageNumber}");
        Console.WriteLine($"The largest number is: {highestNumber}");
        Console.WriteLine($"The smallest number is: {smallestNumber}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        // Display list in sorted order
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }       
        
    }
}