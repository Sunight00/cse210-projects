public class Word
{
    private string _text;


    public  Word()
    {
        _text = "Prayer";
    }
    

    public void Hide()
    {
        _text= new string('_',_text.Length);
    }


    public void Show()
    {

    }

    public bool IsHidden()
    {
        // Implement the logic to determine if the word is hidden
        return false; // Placeholder return value
    }

    public string GetDisplayText()
    {
        return _text;
    }
















}