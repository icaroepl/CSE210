class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        // Eternal goals are never complete, so we don't change any state here.
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete.
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Points: {_points}";
    }
}