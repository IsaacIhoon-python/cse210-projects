using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Bake Bread", "Isaac", 540);
        Video video2 = new Video("Understanding C# OOP", "Bright", 620);
        Video video3 = new Video("Top 10 Hacking Tips", "Fletcher", 480);

        // Add comments to video1 (3 comments)
        video1.AddComment(new Comment("Stanley", "This was very helpful!"));
        video1.AddComment(new Comment("John", "Loved the step-by-step explanation."));
        video1.AddComment(new Comment("Mary", "Can you do a video on packaging bread?"));

        // Add comments to video2 (3 comments)
        video2.AddComment(new Comment("Benjamin", "This is so insightful!"));
        video2.AddComment(new Comment("Prince", "I love the detailed explanation."));
        video2.AddComment(new Comment("Lucky", "Can you also make a video on Python?"));

        // Add comments to video3 (3 comments)
        video3.AddComment(new Comment("Solomon", "Wow! I never thought this was possible."));
        video3.AddComment(new Comment("Francis", "Is this ethical?"));
        video3.AddComment(new Comment("Victoria", "Can you do a follow-up on penetration testing?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine(new string('_', 40));
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
