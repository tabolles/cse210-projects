class Breathing : Activity
{
    public Breathing(string title, string desc, int duration = 0)
        : base(title, desc, duration)
    {
    }

    public void breathingActivity(){

        startActivity();    
        
        _duration = getDuration();

        DateTime end = DateTime.Now.AddSeconds(_duration);
        Console.Write("\nReady?...");
        while (DateTime.Now < end)
        {
            breathingAnimation();
        }

        endActivity();
    }

    private void breathingAnimation()
    {
        List<string> animation = new() {
            "\n\nBreathe in... ", "1", "\b2", "\b3", "\b ",
            "\n\nBreathe out... ", "3", "\b2", "\b1", "\b "
        };
        foreach (string frame in animation)
        {
            Console.Write(frame);
            Thread.Sleep(1000);
        }
    }
        
}