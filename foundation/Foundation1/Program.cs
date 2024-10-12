using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Video video1 = new Video("Learning C# Basics", "John Smith", 35);
        Video video2 = new Video("Advanced C# Programming", "Jane Doe", 55);
        Video video3 = new Video("C# Design Patterns", "Emily Johnson", 25);

        video1.AddComment(new Comment("Alice", "This tutorial worked great for me, thanks!"));
        video1.AddComment(new Comment("Jay", "Very helpful, I was able to understand C# a lot faster than expected."));
        video1.AddComment(new Comment("Kristy", "I learned a lot. It would have been more difficult trying to grasp C# without this tutorial."));

        video2.AddComment(new Comment("Dave", "Clear and concise. I loved how it implemented my knowledge of C# basics and took it to a whole new level."));
        video2.AddComment(new Comment("Eve", "Perfect for my project, thanks!"));
        video2.AddComment(new Comment("Malyk", "Let's goooo! It can still be a bit complicated at times, but it's making more sense now!"));

        video3.AddComment(new Comment("Grace", "Very interesting. I appreciated the opportunity to learn!"));
        video3.AddComment(new Comment("Heidi", "The examples were excellent, thanks a lot for the detailed tutorial!"));
        video3.AddComment(new Comment("Ivan", "Good coverage of patterns! I never would have thought of those concepts like that!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Video Title: {video.video_Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} minutes");
            Console.WriteLine($"Number of Comments: {video.CountComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment._commentAuthor}: {comment._commentText}");
            }
            Console.WriteLine(); 
        }
    }
}
