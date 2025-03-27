using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _chapter;
    private int _verse;
    public int EndVerse { get; private set; }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _chapter = reference.Chapter;
        _verse = reference.StartVerse;
        EndVerse = reference.EndVerse;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        while (hiddenCount < numberToHide && visibleWords.Count > 0)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - " +
               string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
