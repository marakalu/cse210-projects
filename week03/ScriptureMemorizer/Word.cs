using System;

public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    //hidding some words by replacing dem with underscores
    public void Hide()
    {
        isHidden = true;
    }

    //displaying the word whether hidden or visible
    public string GetDisplayText()
    {
        return isHidden ? new string('_', text.Length) : text;
    }

    public bool IsHidden()
    {
        return isHidden;
    }
}