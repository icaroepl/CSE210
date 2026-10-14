abstract class Activity
{
    private protected string _date;
    private protected float _length;


    public Activity(string date, float length)
    {
        _date = date;
        _length = length;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public abstract string GetSummary();

}