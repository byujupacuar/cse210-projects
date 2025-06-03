using System;
using System.Collections.Generic;

class Program
{
    private List<Video> videos;

    public Program()
    {
        videos = new List<Video>();
    }

    public void InitializeVideos()
    {
        Video video1 = new Video("Learning C#", "Juan Pérez", 300);
        video1.Comments.Add(new Comment("María", "Very useful, thank you!"));
        video1.Comments.Add(new Comment("Carlos", "Great explanation!"));

        Video video2 = new Video("Design Patterns", "Ana López", 450);
        video2.Comments.Add(new Comment("Luis", "Incredible content!"));

        videos.Add(video1);
        videos.Add(video2);
    }

    public void DisplayVideos()
    {
        foreach (var video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Program program = new Program();
        program.InitializeVideos();
        program.DisplayVideos();
    }
}
