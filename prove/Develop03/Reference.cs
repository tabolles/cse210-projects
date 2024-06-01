using System;

public class Reference{
    private Dictionary<string, Scripture> _reference;
    private string _currentReference;

    public Reference(){
        _reference = new Dictionary<string, Scripture>();
    }

    public void addSingle(string reference, string scripture){
        _currentReference = reference;
        _reference[reference] = new Scripture(scripture);
    }

    public void addMultiple(string reference, string[] scriptures){
        _currentReference = reference;
        _reference[reference] = new Scripture(scriptures);
    }

    public void displayScripture(){
        Scripture scripture = _reference[_currentReference];
        Console.WriteLine($"Reference: {_currentReference}");
        scripture.displayScripture();
    }

    public void hideRandom(){
        Scripture scripture = _reference[_currentReference];
        Console.Clear();
        scripture.hideRandom();
        scripture.displayScripture();
    }
}