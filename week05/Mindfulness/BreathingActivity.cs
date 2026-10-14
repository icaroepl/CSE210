
class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description, 0)
    {
        
    }
    public void Run()
{
    displayStartingMessage();
    int cycleTime = 10;

    for (int i = 0; i < _duration; i += cycleTime)
    {
        Console.WriteLine("Breathe in...");
        showCountdown(4);
        Console.WriteLine();
        
    
        if (i + 4 >= _duration) break;

        Console.WriteLine("Breathe out...");
        showCountdown(6);
        Console.WriteLine();
    }

    displayEndingMessage();
}
}