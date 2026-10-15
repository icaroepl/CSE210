class SimpleGoal : Goal
{
    bool _isComplete = false;
    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) - Points: {_points}, Complete: {_isComplete}";
    }
}