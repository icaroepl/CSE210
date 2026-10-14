class Swimming : Activity
{

    private float _laps;

    public Swimming(float laps, float length) : base(DateTime.Now.ToString("MM/dd/yyyy"), length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000 * 0.62f; 
    }

    public override float GetSpeed()
    {
        return GetDistance() / (_length / 60) * 60; 
    }

    public override float GetPace()
    {
        return _length / GetDistance(); 
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_length} min): Laps: {_laps}, Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

}