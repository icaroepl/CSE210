using System;

// added at line 48 a safety measure for wrong options

class Program
{
    static void Main(string[] args)
    {
        Prompt prompt = new Prompt();
        SavedFile file = new SavedFile();
        string choice = "";
        
        Console.WriteLine("Wecolme to the Journal Program!");
        while (choice != "5"){
            choice = "";
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                prompt.GetPrompts();
            }    
            else if (choice == "2")
            {
                prompt.DisplayAll();
            }
            else if (choice == "3")
            {
                file.LoadFile(prompt);
            }
            else if (choice == "4")
            {
                file.SaveFile(prompt);
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