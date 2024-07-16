class Lecture : Event{
    string _speaker;
    int _capacity;

    public Lecture(string title, string description, string date, string time, Address location, string speaker, int capacity) : base(title, description, date, time, location){
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string fullDescription(){
        return $"{genericDisplay()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string shortDescription(){
        return $"Lecture\n{_title}\n{_date}";
    }
}