public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference()
    {
        _book="Genesis";
        _chapter= 1;
        _verse=2;
    }
    


    public string GetDisplayText()
    {
        return $"{_book} {_chapter} : {_verse}";
    }

    
}