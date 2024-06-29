class ChecklistGoal : Goal {
    private List<Goal> _items;
    private int _itemsCompleted = 0;



    public ChecklistGoal(string title, string desc, int score) : base(title, desc, score) {
        Console.WriteLine("Enter the items for your checklist goal. Enter 'done' when you are finished.");
        string item = "";
        while (item != "done") {
            Console.Write("Enter a goal:");
            string itemTitle = Console.ReadLine();

            Console.Write("Enter a score value: ");
            string itemScore = Console.ReadLine();

            if (itemTitle != "done" || itemScore != "done") {
                _items.Add(new SimpleGoal(itemTitle, "", int.Parse(itemScore)));
                _itemsCompleted++;
            }
        }
    }

    public override void awardScore() {
        getTotal();
        _totalScore += _score;
        saveTotal();
    }

    public override void display() {
        Console.WriteLine($"Goal: {_title}\nDescription: {_desc}\n");
        Console.WriteLine("Checklist:");
        foreach (Goal item in _items) {
            Console.WriteLine(item.getTitle());
            Console.Write($"\nHave you completed this goal? (y/n): ");
            string response = Console.ReadLine();
            if (response == "y") {
                item.awardScore();
            }
        }
        if (_itemsCompleted == _items.Count) {
            awardScore();
            Console.WriteLine($"\nyour score is now: {_totalScore}\n");
        }

    }
}