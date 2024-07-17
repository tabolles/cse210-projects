abstract class Activity
{
    protected string _date;
    protected string _length;

    public Activity(string date, string length)
    {
        _date = date;
        _length = length;
    }

    public abstract string getSummary();
    public abstract double getDistance();
    public abstract double getSpeed();
    public abstract double getPace();
}