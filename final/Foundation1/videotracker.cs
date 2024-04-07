using System;

namespace YouTubeVideoTracker
{
    class Comment
    {
        public string CommenterName { get; set; }
        public string CommentText { get; set; }
    }

    class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        private List<Comment> Comments { get; set; } // Changed to private for encapsulation

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            LengthInSeconds = length;
            Comments = new List<Comment>();
        }

        public void AddComment(string commenterName, string commentText)
        {
            var comment = new Comment { CommenterName = commenterName, CommentText = commentText };
            Comments.Add(comment);
        }

        public int GetNumComments()
        {
            return Comments.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Length: {LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {GetNumComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }

        // Public method to access comments list if needed externally
        public List<Comment> GetComments()
        {
            return Comments;
        }
    }
}