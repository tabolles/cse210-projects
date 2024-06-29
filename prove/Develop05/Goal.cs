abstract class Goal{
    protected string _title;
    protected string _desc = "";
    protected int _score;
    protected int _totalScore;

    public Goal(string title, string desc, int score) {
        _title = title;
        _desc = desc;
        _score = score;
    }

    public string getTitle(){
        return _title;
    }

    public int getScore(){
        getTotal();
        return _totalScore;
    }
    
    public void getTotal(){
        string[] savedScore = System.IO.File.ReadAllLines("Score.csv");
        foreach (string score in savedScore){
            int currentScore = int.Parse(score);
            int previousScore = _totalScore;
            if (currentScore > previousScore){
                _totalScore = currentScore;
            }
        }
    }

    public void saveTotal(){
        // Delete the previous score file
        if (System.IO.File.Exists("Score.csv"))
        {
            System.IO.File.Delete("Score.csv");
        }

        // Save the new total score
        System.IO.File.WriteAllText("Score.csv", _totalScore.ToString());
    }

    public abstract void awardScore();
    public abstract void display();

}