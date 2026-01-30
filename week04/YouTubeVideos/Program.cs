class Program
{
    static void Main(string[] args)
    {
        // Created videos

        Video video1 = new Video("How to Bake Bread", "Isaac", 540);
        Video video2 = new Video("Understanding C# OOP", "Bright", 620);
        Video video3 = new Video("Top 10 Hacking Tips", "Fletcher", 480);

        
        // Add comments to video1
        video1.AddComment(new Comment("Stanley", "This was very helpful!"));
        video1.AddComment(new Comment("John", "Loved the step-by-step explanation."));
        video1.AddComment(new Comment("Marry", "Can you do a video on how to Package the Bread? "));

        // Add comments to video2
        video2.AddComment(new Comment("Benjamin", "This is so insightful!"));
        video2.AddComment(new Comment("Prince", "I Love the detailed explanation."));
        video2.AddComment(new Comment("Lucky", "Can you also make a video on Python? "));

        // Add comment to video3
        video3.AddComment(new Comment("Solomon", "Wao! I never thought this was possible...."));
        video3.AddComment(new Comment("Francis", "I just want to be sure if its's ethical ."));
        video3.AddComment(new Comment("Victoria", "Can you do a follow-up video on Penetration testing? "));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3};

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine(new string('_', 40));
        }

        // Pause console
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}