class Swimming : Activity
{
    int _laps;

    public Swimming(string date, string length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string getSummary()
    {
        return "Swam " + _laps + " laps on " + _date + " in " + _length + " minutes";
    }

    public override double getDistance()
    {
        return _laps * 0.25;
    }

    public override double getSpeed()
    {
        return getDistance() / double.Parse(_length);
    }

    public override double getPace()
    {
        return double.Parse(_length) / getDistance();
    }
}
