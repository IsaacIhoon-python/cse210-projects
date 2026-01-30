using System;
using System.Collections.Generic;

// Class representing a Comment
public class Comment
{
    // Properties
    public string CommenterName { get; set; }
    public string Text { get; set;}

    // Constructor
    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}
    // Class representing a Video
    public class Video
    {
        // Properties
        public string Title { get; set;}
        public string Author { get; set;}
        public int LengthInSeconds { get; set;}

    
        // List of comments
    private List<Comment> Comments { get; set;}

    // constructor
    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    // Method to add a comment
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Method to display all comments

    public void DisplayComments()
    {
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
    }
}
       







 