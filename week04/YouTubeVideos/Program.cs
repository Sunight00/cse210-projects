using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        
        Video vid1 = new Video("Horror","Jake Cage",12);
        Video vid2 = new Video("Music fest","Luck Matt",3);
        Video vid3 = new Video("Dance again","Collins Fred",4);
        Video vid4 = new Video("Move Up","Smith Williams",5);
        
        List<Video> youtube = new List<Video>();
        youtube.Add(vid1);
        youtube.Add(vid2);
        youtube.Add(vid3);
        youtube.Add(vid4);



        foreach(var vid in youtube)
        {
            vid.Display();
        }
    }
}