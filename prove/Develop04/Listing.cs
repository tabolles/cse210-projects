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
    
            DateTime end = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < end)
            {
                _userInputs.Add(Console.ReadLine());
            }
            
            Console.WriteLine("You listed the following: ", string.Join(", ", _userInputs));

    
            endActivity();
    }
}