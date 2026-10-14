using System;

// Added a protection for invalid choices on the menu
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Menu Options:");
        Console.WriteLine("   1. Breathing Activity");
        Console.WriteLine("   2. Listing Activity");
        Console.WriteLine("   3. Reflecting Activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            breathingActivity.Run();
        }
        else if (choice == "2")
        {
            ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, new List<string> { "List as many things as you can that you are grateful for.", "List as many things as you can that make you happy.", "List as many things as you can that you are proud of." });
            listingActivity.Run();
        }
        else if (choice == "3")
        {
            ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0, new List<string> { "Think of a time when you overcame a challenge.", "Think of a time when you helped someone in need.", "Think of a time when you achieved a goal." }, new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?" });
            reflectingActivity.Run();
        }
        else if (choice == "4")
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option.");
        }
    }

}