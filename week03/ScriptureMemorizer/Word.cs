using System;
using System.Collections.Generic;
using System.Linq;
class Word
{
    private string _text;
    private bool isHidden;

    public Word(string text)
    {
        _text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Show()
    {
        isHidden = false;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public string GetDisplayText()
    {
        return isHidden ? "_____" : _text;
    }
}