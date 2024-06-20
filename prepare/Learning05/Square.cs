class Square : Shape {
    double _side;

    public Square(string color, double side) : base(color) {_side = side;}

    public override double getArea(){
        double squareArea = _side * _side;

        return squareArea;
    }
}