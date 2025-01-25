public class Scripture
{
    Reference newReference = new Reference();
    
    
    private List<Word> _words = new List<Word>();
    public List<string> word = new List<string>();
        



    
    
    public Scripture( )
    {   
        word=["And","God","said","let","there","be","light:","and","there","was","light."];        
    }


    public void HideWords()
    {

        string v = "ffff";
        string abc = new string('_', v.Length);
    }


    public void HideRandomWords(int numberToHide)
    {

    }


    public string GetDisplayText()
    {
        
        var result = string.Join(" ", word);
       return result;
    }


    public bool IsCompletelyHdden()
    {
        return false;
    }
}

