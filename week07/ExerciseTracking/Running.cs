class Running : Activity
{
    private float _distance;

    public Running(float distance, float length) : base(DateTime.Now.ToString("MM/dd/yyyy"), length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / _length * 60; 
    }

    public override float GetPace()
    {
        return _length / _distance; 
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_length} min): Distance: {_distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}