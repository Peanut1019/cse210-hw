using System;
public class Scripture
{
    private string _text;
    public List<Word> _words;
    public int _randomWord;
    public Random _random = new Random();
    Reference r1 = new Reference();
    Word w1 = new Word();
    public string _reference;
   
    public Scripture()
    {
    }

    public Scripture(string text)
    {
        _text = text;
        _words = new List<Word>();
        string [] words = text.Split('_');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
     public void HideRandom()
        {
            do
            {
                _randomWord = _random.Next(_words.Count);
            }
            while (_words[_randomWord]._hidden);
            _words[_randomWord].Hide();
        }
    public string ShowScripture()
        {
            _reference = r1.getReference();
            string all = $"{_reference}-{_text}";
            return all;
        }
}