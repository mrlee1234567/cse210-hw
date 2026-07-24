using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        VideoPlayer vp = new VideoPlayer();
        Video vid = new Video("How to","expllosd",600);
        Comment com = new Comment("expllosd","lik and scubscord");
        vid.AddComment(com);
        vid.AddComment("g0astb0y100","boo");
        vid.AddComment(com);
        vid.AddComment("GROEG","broe, you commented the same thign twics");
        vp.AddVideo(vid);

        vid = new Video("how i maked a monster","aaaaa",351);
        com = new Comment("GROEG","broe, you dint make a no monsert");
        vid.AddComment(com);
        com = new Comment("aaaaa","@GROEG did you wach the vidoe even lol?");
        vid.AddComment(com);
        vid.AddComment("g0astb0y100","boo");
        vid.AddComment("Aliesn","*UFO Flies By*");
        vid.AddComment("g0astb0y100","woah did you see that?");
        vp.AddVideo(vid);

        vid = new Video("Top 10 Funniest Gapmleay Moments 201X","JOHNVIDEOJUEGO",7601);
        com = new Comment("bailar_","que lastima! no incluir el juego");
        vid.AddComment(com);
        vid.AddComment("g0astb0y100","boo");
        vid.AddComment("ilgatong","@g0astb0y100 dud i swear i see you everywhere");
        vid.AddComment("GROEG","@ilgatong broe, its a bot");
        vid.AddComment("JOHNVIDEOJUEGO","@bailar_ lo siento no hablo espannol");
        vp.AddVideo(vid);

        vp.Print();
    }
    /* 
    
    classes:
    Video X
    !req Comment
    _length (int, in seconds)
    _title (string)
    _author (string)
    _comments (List<Comment>)

    --constructor(title st, author st, length int)
    --AddComment(commentObject Comment) - void
    --AddComment(commentor st, contents st) - void, constructs a new Comment within the function
    --DisplayContents() - void, prints title, author, and length followed by each comment
    --CommentCount() - int, returns the count of _comments

    Comment X
    _commenter (string)
    _contents (string)

    --constructor(commentor st, contents st)
    --Print() - void, prints commenter and contents

    VideoPlayer
    !req Video
    _videos (List<Video>)

    --constructor()
    --Print() - void, prints all items in _videos, made to streamline my worklace
    --AddVideo(videoObject Video) - void, adds to _videos

    The Video class contains a method that returns the number of comments directly from the
    way comments are stored (for example returns the length of the list).

    Program runs without errors. It correctly creates at least 3 Video objects (including
    setting their values), and for each Video creates and sets at least 3 Comment objects
    (including setting their values). The Video objects are stored in a list.


     */
}