using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordStrings = text.Split(' ');
        _words = new List<Word>();

        foreach (var word in wordStrings)
        {
            _words.Add(new Word(word));
        }

        _random = new Random();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());

        foreach (var word in _words)
        {
            Console.Write(word.ToString() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = _words.Where(w => !w.IsHidden).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    public string GetReference()
    {
        return _reference.ToString();
    }
}
