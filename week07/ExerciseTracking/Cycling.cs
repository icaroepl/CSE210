class Cycling : Activity
{
    private float _speed;

    public Cycling(float speed, float length) : base(DateTime.Now.ToString("MM/dd/yyyy"), length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * (_length / 60) ;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_length} min): Speed: {_speed} mph, Pace: {GetPace()} min per mile";
    }
}