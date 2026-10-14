
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, List<string> prompts) : base(name, description, duration)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        displayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        displayEndingMessage();
        Console.WriteLine($"You listed {_count} items.");
    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        return prompt;
    }

    public void GetListFromUser()
    {
        Console.WriteLine("You may begin listing items now. Press enter after each item.");      
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("List an item...");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                _count++;
            }
        }
    }
 
}