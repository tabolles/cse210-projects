abstract class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _location;

    public Event(string title, string description, string date, string time, Address location){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _location = location;
    }

    public string genericDisplay(){
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nLocation: {_location.getFullAddress()}";
    }

    public abstract string fullDescription();
    public abstract string shortDescription();
}