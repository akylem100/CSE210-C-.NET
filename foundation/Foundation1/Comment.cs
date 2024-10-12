using System;

public class Comment
{
    public string _commentAuthor { get; private set; }
    public string _commentText { get; private set; }

    public Comment(string commentAuthor, string commentText)
    {
        _commentAuthor = commentAuthor;
        _commentText = commentText;
    }

    public override string ToString()
    {
        return $"{_commentAuthor}: {_commentText}";
    }

}
