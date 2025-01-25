public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public void SetOneVerse(string book, int chapter, int verse)
    {
        _book=book;
        _chapter=chapter;
        _verse=verse;
    }

    public void SetMultiVerse(string book, int chapter, int verse, int endverse)
    {
        _book=book;
        _chapter=chapter;
        _verse=verse;
        _endVerse=endverse;
    }
    

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    
}