class Reflection : Activity
{

    private List<string> _prompts = new(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _probingQuestions = new(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _random = new();

    public Reflection(string title, string desc, int duration = 0) : base(title, desc, duration) {}

    public void reflectionActivity()
    {
        startActivity();

        Console.WriteLine($"\n{_prompts[_random.Next(_prompts.Count)]}\n"); Thread.Sleep(2000);

        Console.WriteLine("Ready?...\n"); Thread.Sleep(2000);

        int nextQuestion = 0;

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write($"{_probingQuestions[nextQuestion]}  "); reflectionAnimation(); nextQuestion++;
            Console.WriteLine("\n\n");
        }

        endActivity();
    }

    private void reflectionAnimation(){

        List<string> animation = new() {
            "\b|","\b/","\b-","\b\\"
        };
        for (int i = 0; i < 25; i++)
        {
            foreach (string frame in animation)
            {
                Console.Write(frame);
                Thread.Sleep(100);
            }
        }
        Console.Write("\b ");
    }
   

}