public abstract class Shape
{
    private string _color;
    public Shape()
    {
        _color = "white";
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }
}