using System;

public class Word{
    private string _word;
    private string _hiddenWord;
    private bool _hidden;


    public Word(string word){
        _word = word;
        _hiddenWord = new string('_', word.Length);
    }

    public string hide()
    {
        _hidden = true;
        return _hiddenWord;
    }

    public string show()
    {
        if (_hidden)
        {
            return _hiddenWord;
        } else {
            return _word;
        }
    }
}