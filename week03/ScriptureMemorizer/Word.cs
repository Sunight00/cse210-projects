public class Word
{
    private string _text;


    public  Word()
    {
        _text = "And God said, Let there be light: and there was light.";
    }


    public string SetWord(string text)
    {   
        _text=text;
        return _text;
    }
    

    public void Hide()
    {
        
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