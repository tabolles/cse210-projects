using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Transactions;

class Video{
    private string _title;
    private string _author;
    private string _length;
    List<Comment> _comments;

    public Video(string title, string author, string length){
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void addComment(string author, string text){
        Comment comment = new Comment(author, text);
        _comments.Add(comment);
    }

    public int getCommentCount(){
        return _comments.Count;
    }

    public void displayComments(){
        foreach(Comment comment in _comments){
            comment.displayComment();
        }
    }

    public void displayVideo(){
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Length: " + _length);
        Console.WriteLine();
        if (getCommentCount() == 1){
            Console.WriteLine("1 Comment:");
        }
        else
        {
            Console.WriteLine($"{getCommentCount()} Comments: ");
        }
        displayComments();
        Console.WriteLine("-----------------------------\n");
    }  
}