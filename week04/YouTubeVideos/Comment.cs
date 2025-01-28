public class Comment
{
    public string _name;
    public string _text;


    public Comment(string name, string feedBack)
    {
       _name=name;
       _text=feedBack;
    }

    public void addComment()
    {
        Video list = new Video();
        list._comments.Add($"{_name}: {_text}");
    }

}

