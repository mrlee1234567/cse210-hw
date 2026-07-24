using System;
using System.Collections.Generic;

class Comment
{
    private string _commenter;
    private string _contents;

    public Comment(string commenter, string contents)
    {
        _commenter = commenter;
        _contents = contents;
    }
    public void Print()
    {
        Console.WriteLine($"{_commenter}: {_contents}");
    }
}