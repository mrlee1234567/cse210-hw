using System;
using System.Collections.Generic;

class VideoPlayer
{
    private List<Video> _videos;
    
    public VideoPlayer()
    {
        _videos = new List<Video>();
    }

    public void AddVideo(Video video)
    {
        _videos.Add(video);
    }

    public void Print()
    {
        Console.WriteLine($"Player with {_videos.Count} videos:");
        foreach (Video i in _videos)
        {
            string iq = $"\nVideo with {i.CommentCount()} Commeents:\n";
            Console.WriteLine(iq);
            i.Print();
        }
    }
}