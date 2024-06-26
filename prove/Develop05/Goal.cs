abstract class Goal{
    protected string _title;
    protected string _desc;
    protected int _score;
    protected int _totalScore;

    public Goal(string title, string desc) {
        _title = title; 
        _desc = desc;
    }

    public int getTotal(){
        string[] savedScore = System.IO.File.ReadAllLines("Score.csv");
        foreach (string score in savedScore){
            int currentScore = int.Parse(score);
            int previousScore = _totalScore;
            if (currentScore > previousScore){
                _totalScore = currentScore;
            }
        }
        if (_score != 0)
        {
            _totalScore += _score;
        }
        return _totalScore;
    }

    public abstract int awardScore();
    public abstract void display();

}