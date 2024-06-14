class Listing : Activity{

    private List<string> _prompts = new(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _userInputs = new();

    private Random _random = new();

    public Listing(string title, string desc, int duration = 0) : base(title, desc, duration) {}

    public void listingActivity(){
            
            startActivity();
    
            _duration = getDuration();

            Console.WriteLine($"\n{_prompts[_random.Next(_prompts.Count)]}\n");
    
            // esablishes the start and end variables used specifically for testing 
            DateTime start = DateTime.Now; DateTime end = DateTime.Now.AddSeconds(_duration); 
            while (start < end)
            {
                _userInputs.Add(Console.ReadLine());
                start = DateTime.Now;
            }
            
            Console.WriteLine($"\nYou were able to list {_userInputs.Count} items.\n");

            endActivity();
    }
}