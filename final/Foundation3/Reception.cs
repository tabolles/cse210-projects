class Reception : Event{
    string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address location, string rsvpEmail) : base(title, description, date, time, location){
        _rsvpEmail = rsvpEmail;
    }

    public override string fullDescription(){
        return $"{genericDisplay()}\nRSVP Email: {_rsvpEmail}";
    }

    public override string shortDescription(){
        return $"Reception\n{_title}\n{_date}";
    }
    
}