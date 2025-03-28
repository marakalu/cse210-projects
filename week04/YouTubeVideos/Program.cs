using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("C# Basics", "Programming Guru", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a part 2?"));

        // Create Video 2
        Video video2 = new Video("Understanding OOP", "TechExplained", 850);
        video2.AddComment(new Comment("Dave", "Clear and concise explanation."));
        video2.AddComment(new Comment("Eve", "OOP is starting to make sense now."));
        video2.AddComment(new Comment("Frank", "Nice examples, keep it up!"));

        // Create Video 3
        Video video3 = new Video("Advanced C# Tips", "CodeMaster", 720);
        video3.AddComment(new Comment("Grace", "Mind-blowing techniques!"));
        video3.AddComment(new Comment("Hank", "Loved the part about LINQ."));
        video3.AddComment(new Comment("Ivy", "Your channel is amazing!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information for each video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}