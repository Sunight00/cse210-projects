public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<string> _comments = new List<string>();

    public Video()
    {
        Comment n = new Comment();
        
        _comments.Add(n._text);
    }

    public int TotalComments()
    {
        int comments = _comments.Count;
        return comments;
    }    
}