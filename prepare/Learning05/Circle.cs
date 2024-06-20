class Circle : Shape{
    double _radius;

    public Circle(string color, double radius) : base(color){
        _radius = radius;
    }

    public override double getArea(){
        double circleArea = Math.PI * _radius * _radius;
        return circleArea;
    }

}
