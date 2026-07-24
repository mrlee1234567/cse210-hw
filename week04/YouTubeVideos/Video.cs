using System;
using System.Collections.Generic;

class Video
{
    private int _length; //video length in seconds
    private string _title;
    private string _author;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLength)
    {
        _length = videoLength;
        _title = title;
        _author = author;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void AddComment(string commenter, string contents)
    {
        Comment cont = new Comment(commenter,contents);
        AddComment(cont);
    }

    public int CommentCount()
    {
        return _comments.Count;
    }

    public void Print()
    {
        string comHeader = $"{_title} ({_length}s) by {_author}\nComments ({_comments.Count}):";
        Console.WriteLine(comHeader);
        foreach (Comment i in _comments)
        {
            i.Print();
        }
    }
}