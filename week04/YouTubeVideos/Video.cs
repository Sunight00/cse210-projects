public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<string> _comments = new List<string>();

    public Video()
    {
        
    }

    public int TotalComments()
    {
        int comments = _comments.Count;
        return comments;
    }    
}