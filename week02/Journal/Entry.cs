public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    
    public void Display()
    { 
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
        

    }
}