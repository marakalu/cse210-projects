using System;
class Comment
{
    public string CommenterName { get; }
    public string Text { get; }

    public Comment(string CommenterName, string text)
    {
        this.CommenterName = CommenterName;
        this.Text = text;
    }
}