class Rectangle : Shape{
    double _length;
    double _width;

    public Rectangle(string color, double length, double width) : base(color){
        _length = length;
        _width = width;
    }
    public override double getArea()
    {
        double rectangleArea = _length * _width;
        return rectangleArea;
    }

}