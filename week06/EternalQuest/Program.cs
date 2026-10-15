using System;

// added an option to erase goals in the menu and added a method to erase goals in the GoalManager class.
class Program
{
    static void Main(string[] args)
    {
        GoalManager questManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("you have 0 points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Erase Goals");
            Console.WriteLine("7. Quit");

            Console.WriteLine("select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                string goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    Console.WriteLine("Enter the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a short description of your goal: ");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter the amount of points associated with this goal: ");
                    string points = Console.ReadLine();

                    questManager.CreateGoal("Simple", name, description, points, 0, 0);
                }
                else if (goalType == "2")
                {
                    Console.WriteLine("Enter the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a short description of your goal: ");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter the amount of points associated with this goal: ");
                    string points = Console.ReadLine();

                    questManager.CreateGoal("Eternal", name, description, points, 0, 0);
                }
                else if (goalType == "3")
                {
                    Console.WriteLine("Enter the name of your goal: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a short description of your goal: ");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter the amount of points associated with this goal: ");
                    string points = Console.ReadLine();
                    Console.WriteLine("Enter the target number of completions for this checklist goal: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the bonus points for completing this checklist goal: ");
                    int bonus = int.Parse(Console.ReadLine());

                    questManager.CreateGoal("Checklist", name, description, points, target, bonus);
                }
            }

            if (choice == "2")
            {
                questManager.ListGoalNames();
                questManager.ListGoalDetails();
            }
            if (choice == "3")
            {
                Console.WriteLine("Which goal would you like to record an event for? (Enter the goal index): ");
                int index = int.Parse(Console.ReadLine());

                questManager.RecordEvent(index);
            }
            if (choice == "4")
            {
                questManager.SaveGoals("goals.txt");
            }
            if (choice == "5")
            {
                questManager.LoadGoals("goals.txt");
            }
            if (choice == "6")
            {
                questManager.EraseGoals();
                Console.WriteLine("Goals have been erased.");
            }
            if (choice == "7")
            {
                Console.WriteLine("Quitting the program.");
                return;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}