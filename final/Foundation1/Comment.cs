class Comment{
    string _author;
    string _text;

    public Comment(string author, string text){
        _author = author;
        _text = text;
    }

    public void displayComment(){
        Console.WriteLine(_author + ": " + _text);
    }
}