using System;
using System.Collections.Generic;
    
 class Program
    {
        static void Main(string[] args)
        {
            var video1 = new Video("Video 1", "Author 1", 300);
            var video2 = new Video("Video 2", "Author 2", 240);
            var video3 = new Video("Video 3", "Author 3", 180);

            video1.AddComment("User1", "Great video!");
            video1.AddComment("User2", "Interesting content");
            video2.AddComment("User3", "Nice explanation");
            video3.AddComment("User4", "Short and sweet");

            var videos = new List<Video> { video1, video2, video3 };

            foreach (var video in videos)
            {
                video.DisplayInfo();
            }
        }
    }
