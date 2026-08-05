class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public new string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()}|Eternal";
    }
        
}