using System;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";
        
        while (choice != "6")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.WriteLine("WHat would you like to do? ");
            Console.Write("");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                WriteNewEntry(journal, promptGenerator);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                LoadJournal(journal);
            }
            else if (choice == "4")
            {
                SaveJournal(journal);
            }
            else if (choice == "5")
            {
                SearchJournal(journal);
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("PLease choose a valid option from the menu.");
                Console.WriteLine();
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("> ");
        string response = Console.ReadLine();

        Console.Write("How would you rate your mood today (1-5)? ");
        string mood = Console.ReadLine();

        string dateText = DateTime.Now.ToShortDateString();
        Entry entry = new Entry(dateText, prompt, response, mood);
        journal.AddEntry(entry);
        Console.WriteLine();
    }

    static void SaveJournal(Journal journal)
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
        Console.WriteLine();
    }

    static void LoadJournal(Journal journal)
    {
        Console.Write("WHat is the file name? ");
        string filename = Console.ReadLine();

        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("File could not be found.");
            Console.WriteLine();
            return;
        }

        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
        Console.WriteLine();

    }

    static void SearchJournal(Journal journal)
    {
        Console.Write("Enter a keyword to search for: ");
        string keyword = Console.ReadLine();
        Console.WriteLine();
        
        bool found = false;

        foreach(Entry entry in journal._entries)
        {
            if (entry._promptText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._mood.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry._date.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
             entry.Display();
             found = true;   
            }
        }

        Console.WriteLine("No matching entries found.");
        Console.WriteLine();
    }

}