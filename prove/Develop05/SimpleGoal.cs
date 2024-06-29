class SimpleGoal : Goal
{
    public SimpleGoal(string title, string desc, int score) : base(title, desc, score){}

    public override void awardScore()
    {
        getTotal();
        _totalScore += _score;
        saveTotal();
    }

    public override void display()
    {
        Console.WriteLine($"Goal: {_title}\nDescription: {_desc}\n");
        Console.Write($"Have you completed this goal? (y/n):");
        string response = Console.ReadLine();
        if (response == "y")
        {
            awardScore();
            Console.WriteLine($"\nyour score is now: {_totalScore}\n");
        }
    }


}