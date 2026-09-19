using System;

// Exceeding Requirements:
// Added safety measure for invalid options at menu.
// Added custom delimiter (~|~) in file save/load to preserve entries properly.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompts();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("dd/MM/yyyy");

                Entry entry = new Entry();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Program Finished");
            }
            else
            {
                Console.WriteLine("Incorrect input, please try again");
            }
        }
    }
}