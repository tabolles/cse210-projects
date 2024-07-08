using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new();
        Video video1 = new Video("The Matrix", "Wachowski", "2:16:00");
        video1.addComment("Alice2702", "I love this movie!");
        video1.addComment("Bob1999", "I love this movie too!");
        video1.addComment("Charlie2003", "I love this movie three!");

        videos.Add(video1);

        Video video2 = new Video("The Matrix Reloaded", "Wachowski", "2:18:00");
        video2.addComment("Alice2702", "Should have stuck with just one.");
        video2.addComment("Bob1999", "great sequel but not as good as the first.");
        video2.addComment("Charlie2003", "I love this movie!");

        videos.Add(video2);

        Video video3 = new Video("The Matrix Revolutions", "Wachowski", "2:09:00");
        video3.addComment("Alice", "STOP MAKING MOVIES");
        video3.addComment("Bob", "I hope that was the last one.");
        video3.addComment("Charlie", "THIS MOVIE IS THE GREATEST MOVIE TO EVER BE RELEASED");

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.displayVideo();
        }
    }
}