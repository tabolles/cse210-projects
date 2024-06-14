using System.Reflection;

class Activity{

    //attributes
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string title, string desc, int duration = 0)
    {
        _duration = duration;
        _desc = desc;
        _title = title;
    }

    public void startActivity()
    {
        Console.WriteLine($"Welcome to {_title}.\n");
        Console.WriteLine($"{_desc}\n");
    }

    public int getDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        return _duration;
    }

    public void endActivity()
    {
        //will display duration in seconds in addition to the title of the activity.
        Console.WriteLine($"Well Done!\n\nYou have completed {_duration} seconds of {_title}.\n"); 
    }
}