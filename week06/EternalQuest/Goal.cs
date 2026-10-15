
public abstract class Goal
{
    private protected string _shortName;
    private protected string _description;
    private protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetPoints()
    {
        return _points;
    }
    public abstract bool IsComplete();
    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

}