using System;
using System.Collections.Generic;
using System.Linq;
class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse == -1 ? startVerse : endVerse;
    }

    public string GetDisplayText()
    {
        return EndVerse > StartVerse
            ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}"
            : $"{Book} {Chapter}:{StartVerse}";
    }
}
