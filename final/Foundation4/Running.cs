class Running : Activity{
    
    private double _distance;

    public Running(string date, string length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string getSummary()
    {
        return "Ran " + _distance + " miles on " + _date + " in " + _length + " minutes";
    }

    public override double getDistance()
    {
        return _distance;
    }
    
    public override double getSpeed()
    {
        return _distance / double.Parse(_length);
    }

    public override double getPace()
    {
        return double.Parse(_length) / _distance;
    }
}