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
        string show = new string(_text);
    }

    public bool IsHidden()
    {
        string underscore = new string('_', _text.Length);
        
        if (_text == underscore )
        {

        }
        // Implement the logic to determine if the word is hidden
        return true; // Placeholder return value
    }

    public string GetDisplayText()
    {
        return _text;
    }
















}