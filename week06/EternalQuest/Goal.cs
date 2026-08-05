class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {
        
    }

    public bool IsComplete()
    {
        return false;
    }

    public string GetDetailsString()
    {
        return $"{_shortName}: {_description} ({_points} points)";
    }

    public string GetStringRepresntation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}