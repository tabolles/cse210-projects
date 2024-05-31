using System;

public class Reference{
    private Dictionary<string, Scripture> _reference;

    public Reference(){
        _reference = new Dictionary<string, Scripture>();
    }

    public void addSingle(string reference, string scripture){
        _reference[reference] = new Scripture(scripture);
    }

    public void addMultiple(string reference, string[] scriptures){
        _reference[reference] = new Scripture(scriptures);
    }

    public void displayScripture(string reference){
        Scripture scripture = _reference[reference];
        Console.WriteLine($"Reference: {reference}");
        scripture.displayScripture();
       
    }
}