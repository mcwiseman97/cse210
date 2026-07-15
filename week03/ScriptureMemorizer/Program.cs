using System;

class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
        }

    }

    static Scripture getRandomeScripture()
    {

    }
}