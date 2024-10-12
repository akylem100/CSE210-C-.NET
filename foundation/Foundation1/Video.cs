using System;
using System.Collections.Generic;

public class Video 
{
    public string video_Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int length)
    {
        video_Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        Comments.Remove(comment);
    }

    public int CountComments()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        return $"Title: {video_Title}\nAuthor: {Author}\nLength: {Length}\nComments: {Comments.Count}";
    }
}
