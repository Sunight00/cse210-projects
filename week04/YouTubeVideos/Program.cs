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
        vid1._comments=["Aweosome","Great","Nice brand","Wow how can i get that!"];
        Comment vidOne = new Comment();
        vidOne._name=["Andrew","fred","Joshua","John"];
        vidOne._text=["Aweosome","Great","Nice brand","Wow how can i get that!"];
       
        






        youtube.Add(vid2);
        vid2._comments=["Aweosome","Great","Nice brand","Wow how can i get that!"];
        Comment vidtwo = new Comment();
        vidtwo._name=["Andrew","fred","Joshua","John"];
        vidtwo._text=["Aweosome","Great","Nice brand","Wow how can i get that!"];

        //youtube.Add(vid3);
        //youtube.Add(vid4);
        


        foreach(var vid in youtube)
        {
            vid.Display();
            Console.WriteLine();
        }
       
       
    }
}