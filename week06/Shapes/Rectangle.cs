
class Rectangle : Shape
{
    private float _width;
    private float _height;

    public Rectangle(string color, float width, float height) : base(color)
    {
        this._width = width;
        this._height = height;
    }

    public override float GetArea()
    {
        return _width * _height;
    }
}