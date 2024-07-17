class Cycling : Activity{

    private double _speed;

    public Cycling(string date, string length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string getSummary()
    {
        return "Cycled at " + _speed + " mph on " + _date + " for " + _length + " minutes";
    }

    public override double getDistance()
    {
        return _speed * double.Parse(_length);
    }

    public override double getSpeed()
    {
        return _speed;
    }

    public override double getPace()
    {
        return 1 / _speed;
    }
}