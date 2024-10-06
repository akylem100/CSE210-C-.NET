using System;

public class Reference
{
    private string _book;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = null;
    }

    public Reference(string book, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public Reference(string book, int startVerse, int? endVerse) 
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        string reference = $"{_book}:{_startVerse}";
        if (_endVerse.HasValue)
        {
            reference += $"-{_endVerse.Value}";
        }
        return reference;
    }

    public bool IsSingleVerse()
    {
        return !_endVerse.HasValue || _startVerse == _endVerse;
    }
}
