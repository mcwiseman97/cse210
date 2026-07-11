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
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
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
        
    }

    static void SaveJournal(Journal journal)
    {
        
    }

    static void LoadJournal(Journal journal)
    {
        
    }

    static void SearchJournal(Journal journal)

}