public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        
    }

    private void Start()
    {
        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals details are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.GetStringRepresentation()}");
        }
    }

    public void CreateGoal(string goalType, string shortName, string description, string points, int target = 0, int bonus = 0)
    {
        Goal newGoal;
        if (goalType == "Simple")
        {
            newGoal = new SimpleGoal(shortName, description, points);
        }
        else if (goalType == "Eternal")
        {
            newGoal = new EternalGoal(shortName, description, points);
        }
        else if (goalType == "Checklist")
        {
            newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
        }
        else
        {
            throw new ArgumentException("Invalid goal type.");
        }

        _goals.Add(newGoal);
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            throw new ArgumentOutOfRangeException("Invalid goal index.");
        }

        Goal goal = _goals[index];
        goal.RecordEvent();
 
        _score += int.Parse(goal.GetPoints());
        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points.");
    
    }
    
        
    

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            throw new FileNotFoundException("The specified file does not exist.");
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string goalType = parts[0];
                    string shortName = parts[1];
                    string description = parts[2];
                    string points = parts[3];

                    if (goalType == "Simple")
                    {
                        _goals.Add(new SimpleGoal(shortName, description, points));
                    }
                    else if (goalType == "Eternal")
                    {
                        _goals.Add(new EternalGoal(shortName, description, points));
                    }
                    else if (goalType == "Checklist")
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                    }
                }
            }
        }
    }

    public void EraseGoals()
    {
        _goals.Clear();
        _score = 0;
    }
    
}