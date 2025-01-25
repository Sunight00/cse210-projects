public class Scripture
{
    Reference newReference = new Reference();
    
    
    private List<Word> _words = new List<Word>();
    public List<string> words = new List<string>();
        



    
    
    public Scripture( )
    {   
        newReference.SetOneVerse("Gensis",1,3);
        newReference.GetDisplayText();
        words=["And","God","said","let","there","be","light:","and","there","was","light."];        
    }


    public void HideWords()
    {   int len = words.Count();
        
        Random ranhide = new Random();
        int fig = ranhide.Next(len);


        string hide = words[fig];

        string underscore = new string('_', hide.Length);

        words[fig]=underscore;
          
    }


    public void HideRandomWords(int numberToHide)
    {

    }


    public string GetDisplayText()
    {

        var result = string.Join(" ", words);
       return $"{newReference.GetDisplayText()} {result}";
    }


    public bool IsCompletelyHdden()
    {
        return false;
    }
}

