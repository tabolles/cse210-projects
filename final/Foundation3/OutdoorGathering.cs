class OutdoorGathering : Event
{
    string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address location, string weather) : base(title, description, date, time, location)
    {
        _weather = weather;
    }

    public override string fullDescription()
    {
        return $"{genericDisplay()}\nWeather: {_weather}";
    }

    public override string shortDescription()
    {
        return $"Outdoor Gathering\n{_title}\n{_date}";
    }
}