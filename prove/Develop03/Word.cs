using System;
public class Word
{
    private string _text;
    public bool _hidden;

    public Word()
    {
    }

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;
    }
}